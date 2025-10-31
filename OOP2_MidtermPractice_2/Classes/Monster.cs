namespace OOP2_MidtermPractice_2.Classes;

public class Monster
{
    private string name;
    private int hp;
    private int damage;
    private int speed;
    private int crit_dmg_percent;
    private int crit_chance;
    private int dodge_chance;
    private ConsoleColor txt_color;
    private string dia_crit;
    private string dia_critdodge;
    private string dia_KO;
    private Monster target;
    private RNG rng;
    //private TextBox txt_box;

    public Monster Target { get { return target; } set { target = value; } }

    public void Attack()
    {
        if (IsCrit())
        {
            TextBox.PrintText(dia_crit, txt_color, 150);
            TextBox.PrintSystemText($"{this.name} is charging a Critical Strike!");
            target.GettingCritAttacked(this.damage + (this.damage * crit_dmg_percent / 100));
        }
        {
            TextBox.PrintSystemText($"{this.name} is goes for an Attack!");
            target.GettingAttacked(this.damage);
        }
    }

    public void GettingAttacked(int damage)
    {
        TextBox.PrintSuspense();

        if (IsDodge())
        {
            TextBox.PrintSystemText($"{this.name} dodges the Attack!");
        }
        {
            TextBox.PrintSystemText($"{this.name} gets hit by the Attack!");
            this.hp -= damage;
            TextBox.PrintSystemText($"{this.name} lost {damage} HP!", ConsoleColor.Red);
        }
    }

    public void GettingCritAttacked(int damage)
    {
        TextBox.PrintSuspense(7, 300);
        TextBox.PrintText("\n-- !!! --", colour: ConsoleColor.DarkYellow);

        if (IsDodge())
        {
            TextBox.PrintSystemText($"{this.name} dodges the Critical Strike!!!!!");
            TextBox.PrintText(dia_critdodge, txt_color, 150);
        }
        {
            TextBox.PrintSystemText($"{this.name} gets struck by the Critical Energy!!!");
            this.hp -= damage;
            TextBox.PrintSystemText($"{this.name} lost {damage} HP!", ConsoleColor.Red);
        }
    }

    public bool IsCrit()
    {
        return (crit_chance >= rng.Random1To100());
    }

    public bool IsDodge()
    {
        return (dodge_chance >= rng.Random1To100());
    }
    public void OnKO()
    {
        TextBox.PrintText(this.dia_KO, this.txt_color, 250);
        TextBox.PrintSystemText($"{this.name} is KO'd!");
    }
   
    public bool IsKO()
    {
        return  this.hp <= 0;
    }
    
    public Monster(string name = "", int hp = 100, int damage = 30, int speed = 50, ConsoleColor txt_color = ConsoleColor.White, string dia_crit = "", string dia_KO = "", string dia_critdodge = "", 
        int c_d_percent = 50, int crit_chance = 30, int dodge_chance = 10)
    {
        this.name = name;
        this.hp = hp;
        this.damage = damage;
        this.speed = speed;
        this.crit_dmg_percent = c_d_percent;
        this.crit_chance = crit_chance;
        this.dodge_chance = dodge_chance;

        this.txt_color = txt_color;
        this.dia_crit = dia_crit;
        this.dia_critdodge = dia_critdodge;
        this.dia_KO = dia_KO;

    }
}