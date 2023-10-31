﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DomesticHelper : Person
    {
        //private string[] Skills { get; set; }
        //private WorkHistory[] WorkHistory { get; set; }
        //private RatingHistory RatingHistory { get; set; }
        //private Contract Contract { get; set; }

        // Attributes
        List<WorkHistory> workHistory;
        List<Rating> ratingHistory;
        List<string> skills;
        List<Contract> contracts;
        float salaryOffer;
        string id;
        string workMode; // Thêm thuộc tính hình thức làm việc

        // Constructor
        public DomesticHelper(string name, string phoneNumber, string address, DateTime dob, float salaryOffer, List<string> skills, string id, string workMode) : base(name, phoneNumber, address, dob)
        {
            this.salaryOffer = salaryOffer;
            this.skills = skills;
            this.id = id;
            this.workMode = workMode; // Thiết lập giá trị cho thuộc tính hình thức làm việc
        }

        // Methods
        public float getSalaryOffer()
        {
            return salaryOffer;
        }

        public override string toString()
        {
            string id = "ID: " + this.id + "\t";
            string info = base.toString();
            info += $"Salary offer: {salaryOffer} \t";
            info += $"Skills: " + string.Join(", ", skills) + "\n";
            info += $"Work mode: {workMode}"; //Hình thức làm việc.
            return id + info;
        }

        public override void printInfo()
        {
            base.printInfo();
        }

        public bool HasSkill(string skill)
        {
            return skills.Contains(skill);
        }
        public string GetLocation()
        {
            return this.address;
        }

        public string GetWorkMode()
        {
            return this.workMode;
        }
    }

}
