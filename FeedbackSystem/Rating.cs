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
        private string foodQuality;
        private string staffFriendliness;
        private string cleanliness;
        private string orderAccuracy;
        private string ambiance;
        private string valueForMoney;

        public Rating(string customerName, string phoneNumber, string emailAddress, string foodQuality, string staffFriendliness, string cleanliness, string orderAccuracy, string ambiance, string valueForMoney) {
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.foodQuality = foodQuality;
            this.staffFriendliness = staffFriendliness;
            this.cleanliness = cleanliness;
            this.orderAccuracy = orderAccuracy;
            this.ambiance = ambiance;
            this.valueForMoney = valueForMoney;
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

        public string FoodQuality
        {
            get { return foodQuality; }
        }

        public string StaffFriendliness
        {
            get { return staffFriendliness; }
        }
        public string Cleanliness
        {
            get { return cleanliness; }
        }
        public string OrderAccuracy
        {
            get { return orderAccuracy; }
        }
        public string Ambiance
        {
            get { return ambiance; }
        }

        public string ValueForMoney
        {
            get { return valueForMoney; }
        }


    }
}
