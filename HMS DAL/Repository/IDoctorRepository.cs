using HMS_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS_DAL.Repository
{
     public interface IDoctorRepository
    {

        void AddDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int DoctorId);
        Doctor GetDoctorById(int DoctorId);
        IEnumerable<Doctor> GetDoctors();
    }
}
