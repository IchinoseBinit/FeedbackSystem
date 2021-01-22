using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackSystem
{
    /*
    * This class is created for serialization
    * The class has the necessary attributes required for the program.
    */
    class Rating
    {
        private string customerName;
        private string phoneNumber;
        private string emailAddress;
        private string[] ratings;
        private string savedDate;

        /*
         * Constructor takes all the value and initializes every attributes
         */
        public Rating(string customerName, string phoneNumber, string emailAddress, string[] ratings, string savedDate)
        {
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.ratings = ratings;
            this.savedDate = savedDate;
        }
        /*
         * Getter method is created to return the values of the private attributes
         */
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
