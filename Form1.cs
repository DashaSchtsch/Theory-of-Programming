using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace лаб4._2
{
    public partial class Form1 : Form
    {
        static ITransport[] transports =
        {
            new PassengerCar("Audi", "1045", "160", "500"),
            new PassengerCar("Scoda", "2078", "170", "500"),
            new PassengerCar("KIA", "0766", "175", "1000"),
            new PassengerCar("Volvo", "4093", "180", "2500"),
            new PassengerCar("Citroen", "1749", "170", "2000"),

            new Motorcycle("BMW", "2857", "70", "yes"),
            new Motorcycle("Kawasaki", "3956", "80", "no"),
            new Motorcycle("BMW", "2047", "75", "yes"),
            new Motorcycle("Yamaha", "4567", "85", "yes"),
            new Motorcycle("Honda", "3856", "90", "no"),

            new Truck("Opel", "2514", "170", "1500", "no"),
            new Truck("Scoda", "4620", "180", "1500", "yes"),
            new Truck("KIA", "4629", "185", "2000", "yes"),
            new Truck("Volvo", "4619", "180", "1750", "no"),
            new Truck("SEAT", "1639", "160", "2000", "no")
        };
        public Form1()
        {
            InitializeComponent();
            transportTypes.SelectedIndex = 0;
        }

        FormManager formManager = new FormManager(transports);

        private void transportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            formManager.Visualize(listBox1, searchBox, transportTypes.SelectedIndex);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            formManager.SearchAndUpdateList(listBox1, searchBox.Text, transportTypes.SelectedIndex);
        }
    }
}
