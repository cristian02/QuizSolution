namespace Model;
public class Father
{
    public Father(int Id, String Name) => (this.Id, this.Name) = (Id, Name); 
    public int Id { get; set; } 
    public String Name { get; set; }

    public override String ToString(){
        return $"Id: {this.Id} Name: {this.Name}";
    }
}
