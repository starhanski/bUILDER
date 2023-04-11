using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern_Character
{
    
    public interface ICharacterBuilder
    {
        void SetHealth(int health);
        void SetStrength(int strength);
        void SetAttack(int attack);
        void SetAbilities(string abilities);
        void SetClass(string className);
        Character GetCharacter();
    }
    [Serializable]
    public class WarriorBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void SetHealth(int health)
        {
            _character.Health = health;
        }

        public void SetStrength(int strength)
        {
            _character.Strength = strength;
        }

        public void SetAttack(int attack)
        {
            _character.Attack = attack;
        }

        public void SetAbilities(string abilities)
        {
            _character.Abilities = abilities;
        }

        public void SetClass(string className)
        {
            _character.Class = className;
        }

        public Character GetCharacter()
        {
            return _character;
        }
    }

    public class MageBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void SetHealth(int health)
        {
            _character.Health = health;
        }

        public void SetStrength(int strength)
        {
            _character.Strength = strength;
        }

        public void SetAttack(int attack)
        {
            _character.Attack = attack;
        }

        public void SetAbilities(string abilities)
        {
            _character.Abilities = abilities;
        }

        public void SetClass(string className)
        {
            _character.Class = className;
        }

        public Character GetCharacter()
        {
            return _character;
        }
    }
    public class ArcherBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void SetHealth(int health)
        {
            _character.Health = health;
        }

        public void SetStrength(int strength)
        {
            _character.Strength = strength;
        }

        public void SetAttack(int attack)
        {
            _character.Attack = attack;
        }

        public void SetAbilities(string abilities)
        {
            _character.Abilities = abilities;
        }

        public void SetClass(string className)
        {
            _character.Class = className;
        }

        public Character GetCharacter()
        {
            return _character;
        }
    }
}
