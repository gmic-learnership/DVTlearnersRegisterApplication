using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DVTLeanersRegisterSystem.SolutionData;

namespace DVTLeanersRegisterSystem
{
    /// <summary>
    /// Interaction logic for DailyRegisterPage.xaml
    /// </summary>
    public partial class DailyRegisterPage : Window
    {
        DatabaseConnections DbaConn = new DatabaseConnections();


        public List<NameAndHours> gridData;
        public List<string> menteeName { get; set; }
        public List<string> mentorName { get; set; }
        public List<int> ID { get; set; } // refactor ID
        public List<int> MenID { get; set; } //refactor MenID
        List<NameAndHours> menteesNames;

        
        public DailyRegisterPage()
        {
            menteeName = retrieveMenteesNames();
            gridData = new List<NameAndHours> { };

            InitializeComponent();
            dtpDate.SelectedDate = DateTime.Now;
            Name.ItemsSource = menteeName;

            mentorName = retrieveMentorsNames();
            cmbbxMentornames.ItemsSource = mentorName;
            dtgNamesAndHours.ItemsSource = gridData;
        }

        private List<string> retrieveMentorsNames()
        {
            try
            {
                using (TheDailyRegisterDbaEntities db = new TheDailyRegisterDbaEntities())
                {
                    List<Person> mentorNamess = (from p in db.Person
                                                 where p.RoleID == 2
                                                 select p).ToList();
                    List<string> Names = new List<string>();
                    
                    foreach (var item in mentorNamess)
                    {
                        Names.Add(item.Name + " " + item.LastName);
                        ID.Add(item.PersonID);
                    }
                    return Names;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); // check proper throw statements
                return null;
            }
        }
        private List<string> retrieveMenteesNames()
        {
            try
            {
                    using(TheDailyRegisterDbaEntities db = new TheDailyRegisterDbaEntities())
	                {
                        List<Person> mentee = (from p in db.Person
                                               where p.RoleID == 1 //check if role 1 is indeed learner
                                               select p).ToList();
                        List<string> menteeName = new List<string>();

                        ID = new List<int>();
                        foreach (var item in mentee)
                        {
                            menteeName.Add(item.Name + " " + item.LastName);
                            ID.Add(item.PersonID);
                        }
                        return menteeName;
	                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); // check proper throw statements
                return null;
            }
         
        }

        private void dtpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RetriveAttendanceDetails();      
        }
        void RetriveAttendanceDetails()
        {
            List<string> names = new List<string>();
            menteesNames = new List<NameAndHours>();

            using (TheDailyRegisterDbaEntities db = new TheDailyRegisterDbaEntities())
            {


                List<AttendanceMaster> mentorAttendanceMater = (from am in db.AttendanceMasters
                                                                where am.Date == dtpDate.SelectedDate
                                                                select am).ToList();


                List<AttendanceDetail> menteeAttendanceDetails = (from ad in db.AttendanceDetails
                                                                  join am in db.AttendanceMasters on ad.AttndncMstrID equals am.AttndncMstrID
                                                                  where am.Date == dtpDate.SelectedDate
                                                                  select ad).ToList();
                try
                {
                    foreach (var item in menteeAttendanceDetails)
                    {
                        foreach (var itemId in ID)
                        {
                            foreach (var trainingOnitem in mentorAttendanceMater)
                            {
                                txtTrainingOn.Text = trainingOnitem.TrainingOn;
                                if (dtpDate.SelectedDate != trainingOnitem.Date)
                                {
                                    cmbbxMentornames.SelectedIndex = 0;
                                    txtTrainingOn.Text = "";
                                }
                            }
                            if (itemId.Equals(item.MenteeID))
                            {
                                names.Add(menteeName.ElementAt(ID.IndexOf(item.MenteeID)));
                                //here
                                //cmbbxMentornames.SelectedIndex = MenID.IndexOf(item.MenteeID);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());// the null reference exception that am getting
                    return;
                }


                for (int i = 0; i < menteeAttendanceDetails.Count; i++)
                {
                    int id = menteeAttendanceDetails[i].MenteeID;
                    List<Person> mentee = (from p in db.Person
                                           where p.PersonID == id
                                           select p).ToList();

                    menteesNames.Add(new NameAndHours(mentee[0].Name + " " + mentee[0].LastName, menteeAttendanceDetails[i].Hours));
                }
                dtgNamesAndHours.ItemsSource = menteesNames;
                dtgNamesAndHours.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //create a separate method called saveAttendanceDetails and just call it inside here
            try
            {
                var attendanceMaster = new AttendanceMaster();
                var attendanceDetails = new AttendanceDetail();

                using (var DbaEntities = new TheDailyRegisterDbaEntities())
                {
                    if (cmbbxMentornames.SelectedIndex > 0 && txtTrainingOn.Text =="")
                    {
                        MessageBox.Show("Enter attendance details correctly first before saving!");//expand the message box with options
                    }
                    else
                    {
                        if (attendanceMaster.Date != dtpDate.SelectedDate)
                        {
                            btnSave.IsEnabled = true;
                            attendanceMaster.Date = dtpDate.SelectedDate.Value;
                            attendanceMaster.TrainingOn = txtTrainingOn.Text;
                            DbaEntities.AttendanceMasters.Add(attendanceMaster);
                            DbaEntities.SaveChanges();
                        }
                        int x = 0;
                        foreach (var itemMentee in menteesNames)
                        {
                            DataGridCell dgc = CustomGridControl.GetCell(dtgNamesAndHours, x, 0);
                            ComboBox cmbx = (ComboBox)dgc.Content;
                            attendanceDetails.Hours = itemMentee.Hours;
                            attendanceDetails.AttndncMstrID = attendanceMaster.AttndncMstrID;

                            attendanceDetails.MenteeID = ID.ElementAt(cmbx.SelectedIndex);
                            DbaEntities.AttendanceDetails.Add(attendanceDetails);
                            DbaEntities.SaveChanges();
                            x++;
                        }
                        MessageBox.Show("Attendance Details Saved");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter attendance details correctly first before saving!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
