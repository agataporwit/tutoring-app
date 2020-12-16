﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace tutoring_app.Models
{
    public class CreateScheduleViewModel
    {
        public List<Student> Students { get; set; }
        public List<Tutor> Tutors { get; set; }
        public List<Subject> Subjects { get; set; }
        public int SelectedStudentId { get; set; }
        public int SelectedTutorId { get; set; }
        public int SelectedSubjectId { get; set; }

        [DisplayName("Appointment Date")]
        public DateTime Date { get; set; }

        public string CreateScheduleConcate() { return "{" + Date.ToString() + "}" + " " + SelectedSubjectId; }
    }
}
