namespace FitAndFabulous.Models
{
    public class PersonTrainingClass
    {
        public int PersonId { get; set; }
        public int TrainingClassId { get; set; }

        public virtual Person Person { get; set; }

        public virtual TrainingClass TrainingClass { get; set; }
    }
}
