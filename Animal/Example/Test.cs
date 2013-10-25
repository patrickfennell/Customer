using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Test
    {
    private string type;
    private string []Continent = new string[5];
    private double weight;
    private int age;
    int i;

    public Test()
    {
        type = "";
        Continent = null;
        weight = 00.00;
        age = 0;
    }
    public Test(string Type,string []Continent, double Weight, int Age)
    {
        Type = type;
        this.Continent = Continent;
        Age = age;
        Weight = weight;
    }
   
        public string getType(){return type;}
        public string[] getContinent() { return Continent; }
        public double getWeight(){return weight;}
        public int getAge(){return age;}

        public void setType(string type)
        {
            this.type = type;
        }
        public void setContinent(string []Continent)
        {
            this.Continent = Continent;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string toString()
        {
            return "Type: {0}\nWeight: {1}\nAge: {2}" + getType() + getWeight() + getAge();
        }
    }
}
