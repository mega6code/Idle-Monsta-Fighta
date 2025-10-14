namespace OOP2_MidtermPractice_2.Classes;

public class Monster
{
    private string name;
    private int hp;
    private int damage;
    private ConsoleColor txt_color;
    private string txt_crit;
    private string txt_KO;
    private Monster target;

    public Monster Target { get { return target; } set { target = value; } }


    public void Attack()
    {
        target.hp -= (this.damage + (IsCrit() ? crit_dmg : 0) ;
    }

    public void IsCrit()
    {
        return (crit_chance >= rand.Next());
    }
    public void OnKO()
    {
        TextBox.PrintText(this.txt_KO, this.txt_color, 250);
        TextBox.PrintSystemText($"{this.name} is KO'd");
    }

    public Monster(string name, int hp, int damage, ConsoleColor txt_color, string txt_crit, string txt_KO)
    {
        this.name = name;
        this.hp = hp;
        this.damage = damage;
        this.txt_color = txt_color;
        this.txt_crit = txt_crit;
        this.txt_KO = txt_KO;

    }
}