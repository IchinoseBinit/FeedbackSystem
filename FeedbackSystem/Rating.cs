using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackSystem
{
    class Rating
    {
        private string customerName;
        private string phoneNumber;
        private string emailAddress;
        private string[] ratings;
        private string savedDate;

        public Rating(string customerName, string phoneNumber, string emailAddress, string[] ratings, string savedDate)
        {
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.ratings = ratings;
            this.savedDate = savedDate;
        }
        public string CustomerName
        {
            get { return customerName; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
        }

        public string[] Ratings
        {
            get { return ratings; }
        }

        public string SavedDate
        {
            get { return savedDate; }
        }

    }
}
