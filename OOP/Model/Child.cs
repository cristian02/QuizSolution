namespace Model;
public class Child : Father
{
    public Child(int Id, string Name) : base(Id, Name)
    {
    }

    public override string ToString()
    {
        return $"Bienvenido {base.ToString()}";
    }

    public string ToString(string key)
    {
        return $"{key} {base.ToString()}"; 
    }
}
