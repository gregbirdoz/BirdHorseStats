using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BirdHorseStats.Models
{
    public class SurvivalModel
    {
        [Required(ErrorMessage = "Please enter whether horse has had surgery")]
        public bool? Surgery { get; set; }
        [Required(ErrorMessage = "Please choose horse age")]
        public string Age { get; set; }
        public string Rectal_temp { get; set; }
        public string Pulse { get; set; }
        public string Respiratory_rate { get; set; }
        public string Temp_of_extremities { get; set; }
        public string Peripheral_pulse { get; set; }
        public string Mucous_membrane { get; set; }
        public string Capillary_refill_time { get; set; }
        public string Pain { get; set; }
        public string Peristalsis { get; set; }
        public string Abdominal_distention { get; set; }
        public string Nasogastric_tube { get; set; }
        public string Nasogastric_reflux { get; set; }
        public string Nasogastric_reflux_ph { get; set; }
        public string Rectal_exam_feces { get; set; }
        public string Abdomen { get; set; }
        public string Packed_cell_volume { get; set; }
        public string Total_protein { get; set; }
        public string Abdomo_appearance { get; set; }
        public string Abdomo_protein { get; set; }
        [Required(ErrorMessage = "Please enter whether horse has had surgical lesion")]
        public bool? Surgical_lesion { get; set; }
        public int Lesion_1 { get; set; }
        public int Lesion_2 { get; set; }
        public int Lesion_3 { get; set; }
        [Required(ErrorMessage = "Please enter whether horse has CP data")]
        public bool? Cp_data { get; set; }

        private string Outcome;
        public void SetOutcome(string o)
        {
            Outcome = o;
        }
        public string GetOutcome()
        {
            return Outcome;
        }

        private string Reasons;
        public void SetReasons(string r)
        {
            Reasons = r;
        }
        public string GetReasons()
        {
            return Reasons;
        }
    }
}
