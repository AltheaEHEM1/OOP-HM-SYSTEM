using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Controllers
{
    public class SuiteController
    {
        public List<Suite> SuitesList { get; private set; }


        // method to add suite room
        public void AddSuiteRoom(int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasJacuzzi, int numberOfRooms)
        {
            using (var context = new DataContext())
            {
                // create instance of Suite 
                Suite suite = new Suite();

                // assign values to the properties
                suite.RoomNumber = roomNumber;
                suite.RoomStatus = roomStatus;
                suite.RoomPrice = roomPrice;
                suite.OccupancyLimit = occupancyLimit;
                suite.HasJacuzzi = hasJacuzzi;
                suite.NumberOfRooms = numberOfRooms;
                suite.IsDeleted = false;

                // add the room to the database
                context.Suites.Add(suite);
                context.SaveChanges();
            }
        }


        // method to read list of suite room
        public List<Suite> GetSuiteRooms()
        {
            using (var context = new DataContext())
            {

                // fetch all data which IsDeleted Column is false
                SuitesList = context.Suites.Where(x => x.IsDeleted == false).ToList();

                // check if the list is empty
                if (SuitesList.Count == 0)
                {
                    // return null if the list is empty
                    return null;
                }
                else
                {
                    // return all suites room
                    return SuitesList;
                }

            }
        }

        // method to edit suite room
        public void EditSuiteRooms(int roomId, int roomNumber, string roomStatus, float roomPrice, int occupancyLimit, bool hasJacuzzi, int numberOfRooms)
        {
            using (var context = new DataContext())
            {
                // fetch the suite room record
                Suite suites = context.Suites.Find(roomId);

                try
                {
                    if (suites == null)
                    {
                        throw new Exception("Suite Room is empty.");
                    }

                    // assign values to the properties
                    suites.RoomNumber = roomNumber;
                    suites.RoomStatus = roomStatus;
                    suites.RoomPrice = roomPrice;
                    suites.OccupancyLimit = occupancyLimit;
                    suites.HasJacuzzi = hasJacuzzi;
                    suites.NumberOfRooms = numberOfRooms;

                    // update the suite room record
                    context.Suites.Update(suites);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // method to delete suite room
        public void DeleteSuiteRoom (int roomId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    // fetch the suite room record base on room id
                    Suite suite = context.Suites.Find(roomId);

                    if (suite == null)
                    {
                        throw new Exception("Deluxe Room does not exist.");
                    }
                    else
                    {
                        // set the IsDeleted column to true
                        suite.IsDeleted = true;

                        // update the suite room record
                        context.Suites.Update(suite);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
