namespace WPF.SQLite.EF.Entity
{
    public class Coach : Person
    {
        public virtual Team Team { get; set; }
    }
}
