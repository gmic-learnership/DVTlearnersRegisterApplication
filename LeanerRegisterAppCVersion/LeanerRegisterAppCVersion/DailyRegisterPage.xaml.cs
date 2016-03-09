using LeanerRegisterAppCVersion.Models;
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

namespace LeanerRegisterAppCVersion
{
    /// <summary>
    /// Interaction logic for DailyRegisterPage.xaml
    /// </summary>
    /// 

    public partial class DailyRegisterPage : Window
    {
        public DailyRegisterPage()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dtpDate.Text = DateTime.Now.ToString();
            using (TheDailyRegisterDBContext db = new TheDailyRegisterDBContext())
            {
                List<Person> selectMentors = (from p in db.Person
                                              join r in db.Roles on p.RoleID equals r.RoleID
                                              where r.RoleID == 2
                                              select p).ToList();
                foreach (var item in selectMentors)
                {
                    // cmbbxMentornames.Items.Clear();
                    cmbbxMentornames.Items.Add(item.Name + "" + item.LastName);
                }
            }
        }

        private void dtpDate_CalendarClosed(object sender, RoutedEventArgs e)
        {
            using (TheDailyRegisterDBContext db = new TheDailyRegisterDBContext())
            {


                List<Person> selectMentors = (from p in db.Person
                                              join r in db.Roles on p.RoleID equals r.RoleID
                                              join am in db.AttendanceMasters on p.PersonID equals am.MentorID
                                              where am.Date == dtpDate.SelectedDate
                                              select p).ToList();
                foreach (var item in selectMentors)
                {
                    cmbbxMentornames.Items.Clear();
                    cmbbxMentornames.Items.Add(item.Name + "" + item.LastName);
                }

                List<AttendanceMaster> getTrainingOn = (from p in db.AttendanceMasters
                                                        where p.Date == dtpDate.SelectedDate
                                                        select p).ToList();

                foreach (var item in getTrainingOn)
                {
                    txtTrainingOn.Text = getTrainingOn[0].TrainingOn;
                }

                List<Person> menteesnames = (from am in db.AttendanceMasters
                                             join ad in db.AttendanceDetails on am.AttndncMstrID equals ad.AttndncMstrID
                                             join p in db.Person on ad.MenteeID equals p.PersonID
                                             join r in db.Roles on p.RoleID equals r.RoleID
                                             where am.Date == dtpDate.SelectedDate
                                             where r.RoleID == 1
                                             select p).ToList();
                                     //p.Name + p.LastName
                                     //).ToList();
                                     //{
                                     //    dgcbxNames.ItemsSource = menteesnames;
                                     // }
                                    //select new
                                    //{
                                    //    p.Name,
                                    //    ad.hours
                                    //}).ToList();

                foreach (var item in menteesnames)
                {
                    dtgNamesAndHours.ItemsSource = menteesnames;
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //save attendance details to respective tables
            MessageBox.Show("TEST!! data should be saved on the database");
        }
    }
}
