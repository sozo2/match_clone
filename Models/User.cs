using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Match.Models
{
        public class User : BaseEntity{
        public int UserId { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public byte picture { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string seeking { get; set; }

        public int PreferenceId { get; set; }
        public Preference Preference {get; set;}
        
        public List<string> interests { get; set; }

        [InverseProperty("PersonLiking")]
        public List<Like> likes { get; set; }

        [InverseProperty("PersonLiked")]
        public List<Like> likers { get; set; }

        public List<int> MatchIds { get; set; }
        public List<int> MatchPercentages { get; set; }

        [InverseProperty("Sender")]
        public List<Message> messagesSent { get; set; }

        [InverseProperty("Reciever")]
        public List<Message> messagesRecieved { get; set; }
        public int salary { get; set; }
        public int height { get; set; }
        public string build { get; set; }
        public string ethnicity { get; set; }
        public int zipcode { get; set; }
        public string history { get; set; }
        public string present_kids { get; set; }
        public string future_kids { get; set; }
        public string drinking { get; set; }
        public string marijuana { get; set; }
        public string Trump { get; set; }
        public int memes { get; set; }
        public string religion { get; set; }
        public string horoscope { get; set; }
        public string exercise { get; set; }
        public string education { get; set; }
        public bool tattoos { get; set; }
        public string diet { get; set; }
        public string sex { get; set; }
        public string cigarettes { get; set; }
        public bool chipotle { get; set; }
        public string pets { get; set; }
        public List<string> netflix {get; set;}
       
        public User()
        {
            interests = new List<string>();
            netflix = new List<string>();
            messagesRecieved = new List<Message>();
            messagesSent = new List<Message>();
            likes = new List<Like>();
            likers = new List<Like>();
            MatchIds = new List<int>();
            MatchPercentages = new List<int>();
            salary = 0;
            height = 0;
            build = "";
            ethnicity = "";
            zipcode = 0;
            history = "";
            present_kids = "";
            future_kids = "";
            drinking = "";
            marijuana = "";
            Trump = "";
            memes = 0;
            religion = "";
            horoscope = "";
            exercise = "";
            education = "";
            tattoos = false;
            diet = "";
            sex = "";
            cigarettes = "";
            chipotle = true;
            pets = "";
            netflix = new List<string>();
        }
    }
}