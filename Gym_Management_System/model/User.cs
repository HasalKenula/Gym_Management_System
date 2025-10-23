using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.model
{
    public class User
    {
        private string id;
        private string username;
        private string name;
        private int age;
        private double height, weight;
        private string gender;
        private string bloodGrp;
        private DateTime dateOfBirth;
        private string email;
        private string phone;
        private String trainer;
        private byte[] photo;

        public User()
        {
        }

        public User(string id, string username, string name, int age, double height, double weight, string gender, string bloodGrp, DateTime dateOfBirth, string email, string phone, string trainer)
        {
            this.id = id;
            this.username = username;
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
            this.bloodGrp = bloodGrp;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phone = phone;
            this.trainer = trainer; 
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BloodGrp { get => bloodGrp; set => bloodGrp = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Trainer { get => trainer; set => trainer = value; }
        public byte[] Photo {  get => photo; set => photo = value;}
    }
}
