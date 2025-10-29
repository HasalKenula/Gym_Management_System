using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.pages.user.dashboard.components
{
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
            LoadAnnouncements();
        }

        public Panel getAnnouncementPanel()
        {
            return pnlAnnouncement;
        }

        private class AnnouncementData
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Date { get; set; }
        }

        private List<AnnouncementData> GetAnnouncements()
        {
            return new List<AnnouncementData>
            {
                new AnnouncementData {
                    Title = "⏰ Holiday Hours Update!",
                    Content = "Please note our modified operating hours for the upcoming public holiday on [Date]. We will be open from 8:00 AM - 1:00 PM. No evening classes.",
                    Date = "Oct 27, 2025"
                },
                new AnnouncementData {
                    Title = "🛠️ Equipment Maintenance Notice",
                    Content = "The cardio section (treadmills 1-4) will be temporarily closed on [Date] from 10:00 AM to 12:00 PM for scheduled maintenance. Thank you for your patience!",
                    Date = "Oct 25, 2025"
                },
                new AnnouncementData {
                    Title = "🎉 New Yoga Class Added!",
                    Content = "Join our new 'Sunrise Flow' yoga class every Tuesday and Thursday morning at 6:30 AM in Studio B. Sign-ups are open now in the Class Booking section!",
                    Date = "Oct 20, 2025"
                },
                new AnnouncementData {
                    Title = "🦠 Winter Flu Safety Protocol Reminder",
                    Content = "Please remember to wipe down all equipment after use and use the provided hand sanitizer stations to keep our gym safe and healthy for everyone.",
                    Date = "Oct 15, 2025"
                }
            };
        }

        private void LoadAnnouncements()
        {
            int currentY = 10;
            int announcementSpacing = 15;
            int announcementWidth = pnlAnnouncement.Width - 30;

            Label headerTitle = new Label();
            headerTitle.Text = "Announcements";
            headerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold); // Made the font larger for a proper heading
            headerTitle.AutoSize = true;
            headerTitle.Location = new Point(10, currentY);
            pnlAnnouncement.Controls.Add(headerTitle);

            currentY = headerTitle.Bottom + 20;

            foreach (var announcement in GetAnnouncements())
            {
                Panel announcementPanel = CreateAnnouncementPanel(announcement, currentY, announcementWidth);
                pnlAnnouncement.Controls.Add(announcementPanel);

                
                currentY += announcementPanel.Height + announcementSpacing;
            }
        }

        private Panel CreateAnnouncementPanel(AnnouncementData data, int yPosition, int width)
        {
            
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.FromArgb(245, 245, 245); 
            panel.Location = new Point(10, yPosition);
            panel.Width = width;
            panel.Padding = new Padding(10);

            
            Label titleLabel = new Label();
            titleLabel.Text = data.Title;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(10, 10);
            panel.Controls.Add(titleLabel);

            
            Label dateLabel = new Label();
            dateLabel.Text = data.Date;
            dateLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            dateLabel.ForeColor = Color.Gray;
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(15, titleLabel.Bottom + 5);
            panel.Controls.Add(dateLabel);

            
            Label contentLabel = new Label();
            contentLabel.Text = data.Content;
            contentLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            contentLabel.MaximumSize = new Size(width - 40, 0);
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(10, dateLabel.Bottom + 10);
            panel.Controls.Add(contentLabel);

            
            int requiredHeight = contentLabel.Bottom + 10;
            panel.Height = requiredHeight;

            return panel;
        }
    }
}
