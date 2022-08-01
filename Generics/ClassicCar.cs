using System;

namespace Rhcodepi
{
    internal class ClassicCar
    {
        public string? m_Make {get; set;}
        public string? m_Model {get; set;}
        public int m_Year {get; set;}
        public int m_Value {get; set;}

        public ClassicCar(string make, string model, int year, int val){
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }

    }
}