namespace OOP2_MidtermPractice_2.Classes;

public class Monster
{
    public static Random random = new Random();
    
    private string name;
    private int hp;
    private int damage;
    private int crit_hit;
    private Monster target;

    private int crit_dmg {
        get {return  }
    };
    

    public bool IsDead()
    {
        return  this.hp <= 0;
    }
    
    public Monster(string name, int hp, int damage)
    {
        this.name = name;
        this.hp = hp;
        this.damage = damage;
    }
    
//yo?
}