namespace OOP2_MidtermPractice_2.Classes;

public class Monster
{
    private string name;
    private int hp;
    private int damage;
    private int crit_dmg_percent;
    private int crit_chance;
    private int dodge_chance;


    private ConsoleColor txt_color;
    private string txt_crit;
    private string txt_KO;

    private Random2 rand;
    private Monster target;

    public Monster Target { get { return target; } set { target = value; } }

    public void Attack()
    {
        target.hp -= (this.damage + (IsCrit() ? (this.damage * crit_dmg_percent / 100) : 0) );
    }

    public bool IsCrit()
    {
        return (crit_chance >= rand.Next());
    }

    public bool IsDodge()
    {
        return (dodge_chance >= rand.Next());
    }
    public void OnKO()
    {
        TextBox.PrintText(this.txt_KO, this.txt_color, 250);
        TextBox.PrintSystemText($"{this.name} is KO'd");
    }
   
    public bool IsKO()
    {
        return  this.hp <= 0;
    }
    
    public Monster(string name, int hp, int damage, ConsoleColor txt_color, string txt_crit, string txt_KO, 
        int c_d_percent = 50, int crit_chance = 30, int dodge_chance = 10)
    {
        rand = new Random2();

        this.name = name;
        this.hp = hp;
        this.damage = damage;
        this.crit_dmg_percent = c_d_percent;
        this.crit_chance = crit_chance;
        this.dodge_chance = dodge_chance;

        this.txt_color = txt_color;
        this.txt_crit = txt_crit;
        this.txt_KO = txt_KO;

    }
}