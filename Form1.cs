using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MovieTheaterManagementSystem_Improved
{

    public partial class Form1 : Form
    {
        private List<Movie> movies = new();
        private List<Booking> bookings = new();
        private readonly string movieFile = "movies.json";
        private readonly string bookingFile = "bookings.json";
        private readonly decimal ticketPrice = 10.00m;


        public Form1()
        {
            InitializeComponent();
            LoadData();
            RefreshMovieList();
        }

        private void LoadData()
        {
            if (File.Exists(movieFile))
                movies = JsonSerializer.Deserialize<List<Movie>>(File.ReadAllText(movieFile)) ?? new();

            if (File.Exists(bookingFile))
                bookings = JsonSerializer.Deserialize<List<Booking>>(File.ReadAllText(bookingFile)) ?? new();
        }

        private void SaveData()
        {
            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                Title = "Save Movie Data",
                FileName = "movies.json"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveDialog.FileName, json);
                MessageBox.Show("Movie data saved successfully.");
            }
        }

        private void RefreshMovieList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = movies.Select(m => m.ToString()).ToList();
            comboBox1.DataSource = movies.Select(m => m.Title).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string genre = textBox2.Text.Trim();
            string durationText = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre) || !int.TryParse(durationText, out int duration) || duration <= 0)
            {
                MessageBox.Show("Please enter valid movie details.");
                return;
            }

            movies.Add(new Movie { Title = title, Genre = genre, Duration = duration });
            RefreshMovieList();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || !DateTime.TryParse(textBox4.Text, out DateTime showtime))
            {
                MessageBox.Show("Select a movie and enter a valid showtime.");
                return;
            }

            var movie = movies.FirstOrDefault(m => m.Title == comboBox1.SelectedItem.ToString());
            movie?.Showtimes.Add(showtime);
            MessageBox.Show("Showtime added.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string customer = textBox5.Text.Trim();
            string seat = comboBox2.SelectedItem?.ToString();
            string movieTitle = comboBox1.SelectedItem?.ToString();
            DateTime showtime;

            if (string.IsNullOrWhiteSpace(customer) || string.IsNullOrWhiteSpace(seat) || !DateTime.TryParse(textBox4.Text, out showtime))
            {
                MessageBox.Show("Please fill all booking details correctly.");
                return;
            }

            bookings.Add(new Booking
            {
                CustomerName = customer,
                MovieTitle = movieTitle,
                Showtime = showtime,
                SeatNumber = seat,
                Price = ticketPrice
            });

            MessageBox.Show("Booking confirmed.");
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data saved.");
        }
    }
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public float Duration { get; set; }
        public List<DateTime> Showtimes { get; set; } = new();
        public override string ToString()
        {
            return $"{Title} ({Genre}, {Duration} min)";
        }
    }

    public class Booking
    {
        public string CustomerName { get; set; }
        public string MovieTitle { get; set; }
        public DateTime Showtime { get; set; }
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{CustomerName} - {MovieTitle} at {Showtime:g}, Seat {SeatNumber}, ${Price}";
        }
    }
}
