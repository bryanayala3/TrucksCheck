namespace PracticeExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        List<Trucks> storeData= new List<Trucks>();
        int id = 0;
        Trucks trucksInfo;

        private void button1_Click(object sender, EventArgs e)
        {
            //internal variables
            int truckNumber=0;
            double gross=0;
            double tare=0;
            DateTime date;
            int recordNumber;

            messageLabel.Text = "";
            recordDisplayed.Clear();
            if (recordIDBox.Text != "" && truckIDBox.Text != "" && grossWeightBox.Text != "" && tareWeightBox.Text != "")
            {
                try
                {
                    truckNumber = Convert.ToInt32(truckIDBox.Text);
                    if(truckNumber == 0 )
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception)
                {
                    messageLabel.Text= messageLabel.Text +"Please Enter an integer number greater than Zero as a Truck ID\r\n";
                }
                try
                {
                    gross = Convert.ToDouble(grossWeightBox.Text);
                    if (gross == 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }    
                catch(Exception)
                {
                    messageLabel.Text = messageLabel.Text + "Please Enter a number greater than Zero as a Gross Weight\r\n";
                }
                try
                {
                    tare = Convert.ToDouble(tareWeightBox.Text);
                    if (tare == 0 || tare > gross) 
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception)
                {
                    messageLabel.Text =messageLabel.Text + "Please Enter a number greater than Zero and lower tha Gross Weight as a Tare Weight\r\n";
                }
                date = dateMeasured.Value.Date;

                try
                {
                    if (date > DateTime.Now.Date)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch
                {
                    messageLabel.Text =messageLabel.Text + "Please do not Enter a date in the future.\r\n";
                }
                if (messageLabel.Text == "")
                {
                    recordNumber = id;

                    var idValidation = storeData.Where(x => x.recordId == id.ToString()).FirstOrDefault();

                    if (idValidation == null)
                    {

                        trucksInfo = new Trucks(recordNumber, truckNumber, gross, tare, date);

                        storeData.Add(trucksInfo);

                        messageLabel.Text = "Record was saved succesfully";

                        DisplayRecords();
                    }
                    else
                    {
                        messageLabel.Text = "Please press New Record to generate a unique Record ID";
                    }
                }
            }
            else
            {
                messageLabel.Text = "Please fill out all inputs";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id = id + 1;
            recordIDBox.Text=id.ToString();

            part2 Part2 = new part2();

            Part2.Show();
        }

        private void newRecordBttn_Click(object sender, EventArgs e)
        {
            id= id + 1;
            recordIDBox.Text = id.ToString();
            truckIDBox.Text = "";
            grossWeightBox.Text = "";
            tareWeightBox.Text = "";
            dateMeasured.Value = DateTime.Now.Date;
            messageLabel.Text = "";
            //recordDisplayed.Clear();
        }

        private void overweightBttn_Click(object sender, EventArgs e)
        {
           recordDisplayed.Clear(); 
             
           foreach(Trucks truck in storeData)
            {
                if (truck.grossWeight >= 65000)
                {
                    recordDisplayed.AppendText("Record ID: " + truck.recordId + "\n");
                    recordDisplayed.AppendText("Truck ID: " + truck.truckId + "\n");
                    recordDisplayed.AppendText("Gross Weight: " + truck.grossWeight + "\n");
                    recordDisplayed.AppendText("Tare Weight: " + truck.tareWeight + "\n");
                    recordDisplayed.AppendText("Date Measured: " + truck.dateMeasured + "\n");
                    recordDisplayed.AppendText("\n");

                }
            }
        }

        public void DisplayRecords()
        {
                foreach (Trucks truck in storeData)
                {

                    recordDisplayed.AppendText("Record ID: " + truck.recordId + "\n");
                    recordDisplayed.AppendText("Truck ID: " + truck.truckId + "\n");
                    recordDisplayed.AppendText("Gross Weight: " + truck.grossWeight + "\n");
                    recordDisplayed.AppendText("Tare Weight: " + truck.tareWeight + "\n");
                    recordDisplayed.AppendText("Date Measured: " + truck.dateMeasured + "\n");
                    recordDisplayed.AppendText("\n");
                }
            
        }
    }
}