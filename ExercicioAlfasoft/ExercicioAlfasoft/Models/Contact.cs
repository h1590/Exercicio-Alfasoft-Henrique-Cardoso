﻿namespace ExercicioAlfasoft.Models
{
    public class Contact
    {
        public bool isDeleted { get; set; }

        public int Id { get; set; }

        public string name { get; set; }

        public string phoneNumber { get; set; }

        public string email { get; set; }

        public Contact()
        {

        }
    }
}
