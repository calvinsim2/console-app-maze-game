﻿namespace MazeGameDomain.Constants
{
    public static class InGameMessage
    {
        public static readonly string BlankRow = string.Empty;
        public static readonly string PromptName = "Insert your Name:";
        public static readonly string ChooseClass = "Choose your desired Class....";
        public static readonly string Warrior = "Warrior - Warriors are adept in close combat, making them exceptional in compact and tight environments" +
            "\n In addition, warriors have higher constitution compared to their counterparts." +
            "\n However, their drawbacks are areas that are vast and wide, which makes them hard to attack opponents.";

        public static readonly string Magician = "Magician - Magicians are suited for combats in any environment." +
            "\n In addition, magicians have the capability to opt for specialisations (Fire / Ice) , which give them an advantage on some maps." +
            "\n However, magicians have lower constitution compared to their counterparts.";

        public static readonly string Archer = "Archer - Archer are adept in range combat, making them exceptional in wide and vast environments," +
            "\n they are able to engage their foes while keeping out of harms way." +
            "\n However, archers struggle in compact and tight environments.";

        public static readonly string PromptClassSelection = "Please select your desired class:" +
            "\n 1 - Warrior" +
            "\n 2 - Magician" +
            "\n 3 - Archer";

        public static readonly string InvalidClassSelection = "Invalid class selected, please input the correct selections:" +
            "\n 1 - Warrior" +
            "\n 2 - Magician" +
            "\n 3 - Archer";

        public static readonly string PromptCombatDecision = "Choose an action:" + "\n1 - Combat" + "\n2 - Items";
        public static readonly string InvalidCombatDecisionSelection = "Invalid decision selected, please input the correct decision.";

        public static readonly string PromptSkill = "Select a skill:";

        public static string AdventurerSkillMessage(int index, string skillName, decimal mpCost, decimal damage)
        {
            return $"{index} - {skillName}, MP: {mpCost}, Damage: {damage}";
        }
        public static string AdventurerInsufficientMPSkillMessage(int index, string skillName, decimal mpCost, decimal damage)
        {
            return $"{index} - {skillName}, MP: {mpCost} (Not Enough Mana), Damage: {damage}";
        }

        public static readonly string InvalidSkillOptionSelection = "Invalid skill option selected, please input the correct selection.";
        public static readonly string InsufficentManaSelection = "Insufficient mana, consume a potion or choose another attack.";
    }
}
