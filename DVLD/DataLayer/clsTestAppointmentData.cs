using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
   public class clsTestAppointmentData
   {
      public static int AddNewTestAppointment(
             int TestTypeID, int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate, float PaidFees, int CreatedByUserID, int RetakeTestApplicationID)
      {
         int TestAppointmentID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert into TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,RetakeTestApplicationID)
                        Values(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@RetakeTestApplicationID);
                        SELECT SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue();

         return TestAppointmentID;
      }
   }
}
