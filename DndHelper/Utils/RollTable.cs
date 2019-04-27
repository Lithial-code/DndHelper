using dndHelperRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndHelper.Utils
{
    public class RollTable
    {
        public static String WildCast()
        {
            int dice = DiceRoller.randInt(1, 100);
            string magic = "";
            switch (dice)
            {
                case 1:
                    magic = "Your magic backfires and you drop to 0 hitpoints and fall unconscious.";
                    break;
                case 2:
                    magic = "Roll on this table for each of your turns for the next minute, ignoring this result in subsequent turns.";
                    break;
                case 3:
                    magic = "For the next minute when you attempt to speak you must sing.";
                    break;
                case 4:
                    magic = "Your focus expands and for the next minute you can see any invisible creatures to which you have line of sight.";
                    break;
                case 5:
                    magic = "You cast Stinking Cloud centered on yourself.";
                    break;
                case 6:
                    magic = "A Modron chosen and controlled by the DM appears in an unoccupied square within 5 ft.of you and disappears after 1 minute.";
                    break;
                case 7:
                    magic = "For the next hour, all objects not being worn or carried that you touch turns to gold.Unfortunately, the effect reverses and all touched objects revert to their original materials when the hour is up.";
                    break;
                case 8:
                    magic = "You cast Fireball as a 3rd level spell centered on yourself.";
                    break;
                case 9:
                    magic = "You cast Blink.";
                    break;
                case 10:
                    magic = "You cast Magic Missile as a 5th level spell";
                    break;
                case 11:
                    magic = "You hiccup uncontrollably for the next hour. When casting a spell with a verbal component, you must succeed a DC 10 Constitution saving throw to cast the spell without being interrupted by your hiccups.If a failed save causes the spell not to trigger, you do not expend the spell slot.";
                    break;
                case 12:
                    int roll = DiceRoller.randInt(1, 10);
                    if (roll % 2 != 0)
                    {
                        magic = ("You shrink by " + roll + " inches");
                    }
                    else
                    {
                        magic = ("You grow by " + roll + " inches");
                    }
                    break;
                case 13:
                    magic = "Roll 2 more times on this table. Both effects trigger simultaneously. Ignore this result and roll again if you roll this number again on one of those two rolls.";
                    break;
                case 14:
                    magic = "You cast Confusion centered on yourself.";
                    break;
                case 15:
                    roll = DiceRoller.randInt(1, 20);
                    if (roll % 2 != 0)
                    {
                        magic = "You cast Enlarge on a random creature within range (including yourself).";
                    }
                    else
                    {
                        magic = "You cast Reduce on a random creature within range (including yourself).";
                    }
                    break;
                case 16:
                    magic = "You feel a refreshing energy well up within you, invigorating you and stitching your wounds shut. For the next minute you regain 5 hitpoints at the start of each of your turns.";
                    break;
                case 17:
                    magic = " You cast Banishment on a random creature within range.";
                    break;
                case 18:
                    magic = "You grow a long beard made of feathers that remains until you sneeze, at which point the feathers explode from your face.";
                    break;
                case 19:
                    roll = DiceRoller.randInt(1, 6);
                    magic = "You grow roots and cannot move for " + roll + " turns.";
                    break;
                case 20:
                    magic = "You cast Grease centered on yourself.";
                    break;
                case 21:
                    roll = DiceRoller.randInt(1, 4);
                    magic = "You forget how to read and write any languages you know for " + roll + " days.If you are already illiterate, you suddenly find yourself able to read common for " + roll + " days.";
                    break;
                case 22:
                    magic = "You feel as if luck is on your side and your next spell will certainly succeed.Creatures have disadvantage on saving throws against the next spell you cast in the next minute that involves a saving throw.";
                    break;
                case 23:
                    magic = "You cast Slow centered on yourself. The 6 affected creatures are chosen randomly if there are more than 6 creatures, including yourself, in the affected area";
                    break;
                case 24:
                    roll = DiceRoller.randInt(0, 5);
                    string[] color = { "blue", "lime green", "hot pink", "yellow", "purple", "red." };
                    magic = "Your skin turns a vibrant " + color[roll] + " . A remove curse spell can end this effect.";
                    break;
                case 25:
                    magic = "You cast Call Lightning centered on yourself. ";
                    break;
                case 26:
                    magic = "An eye appears on your forehead for the next hour. During that time you have advantage on any Wisdom (perception)checks that rely on sight.";
                    break;
                case 27:
                    roll = DiceRoller.randInt(0, 11);
                    int roll2 = DiceRoller.randInt(0, 11);
                    while (roll == roll2)
                    {
                        roll2 = DiceRoller.randInt(0, 11);
                    }
                    string[] lang = { "common", "giant", "goblin", "draconic", "elvish", "infernal", "dwarvish", "orc", "gnomish", "deep speech", "primordial", "celestial" };
                    magic = "For the next hour you can only speak " + lang[roll] + " and can only understand " + lang[roll];
                    break;
                case 28:
                    magic = "Your mind is quickened and everything around you seems to move in slow motion. For the next minute, all of your spells with a casting time of 1 action have a casting time of 1 bonus action.";
                    break;
                case 29:
                    magic = "Your biological sex is reversed and your physical features change to match.All changes reverse after 24 hours.";
                    break;
                case 30:
                    magic = "You teleport up to 60 ft. to an unoccupied square of your choice you can see.";
                    break;
                case 31:
                    magic = "An Imp controlled by the DM appears in an unoccupied square within 5 ft.of you. It vanishes 1 minute later.";
                    break;
                case 32:
                    magic = "You are transported to the Astral plane until the end of your next turn, at which time you return to the space you previously occupied or the nearest unoccupied space if it is occupied.";
                    break;
                case 33:
                    magic = "You cast Stoneskin on yourself";
                    break;
                case 34:
                    magic = "Your raw magic feels too powerful to control and you know that your next strike will certainly be lethal. Maximize the damage of the next damaging spell you cast within the next minute";
                    break;
                case 35:
                    magic = "You cannot lie for the next hour. If you attempt to tell a lie, your mouth seals itself shut and will not open until the hour is up.";
                    break;
                case 36:
                    roll = DiceRoller.randInt(1, 10);
                    if (roll % 2 != 0)
                    {
                        magic = ("You grow " + roll + " years younger");
                    }
                    else
                    {
                        magic = ("You grow " + roll + " years older");
                    }
                    break;
                case 37:
                    magic = "A random creature within 30 ft. of you falls madly in love with you for the next 24 hours.";
                    break;
                case 38:
                    //TODO add flumphs
                    roll = DiceRoller.randInt(1, 6);
                    magic = roll + " Flumphs controlled by the DM appear in spaces within 60 ft of you and are frightened by you. They vanish after 1 minute.";
                    break;
                case 39:
                    magic = "Your ears grow as large as dinner plates and you have advantage on Wisdom(perception) checks involving hearing.Both effects fade after 1 hour.";
                    break;
                case 40:
                    roll = DiceRoller.randInt(2, 20);
                    magic = "You suddenly feel your wounds stitch themselves back up. You regain " + roll + " hitpoints.";
                    break;
                case 41:
                    roll = DiceRoller.randInt(1, 4);
                    magic = "Time stops for you and all creatures in a 10 ft. radius around you for " + roll + " rounds.";
                    break;
                case 42:
                    magic = "You turn into a potted plant until the start of your next turn. While a plant you are incapacitated and have vulnerability to all damage. If you drop to 0 hitpoints your pot breaks and your form reverts.";
                    break;
                case 43:
                    magic = "Your shadow vanishes. It does not return unless you roll this result again.";
                    break;
                case 44:
                    magic = "For the next minute you can teleport up to 20 ft. as a bonus action on each of your turns.";
                    break;
                case 45:
                    magic = "You feel a modicum of control over your magic returning. You regain half of your expended sorcery points.";
                    break;
                case 46:
                    magic = "You cast Levitate on yourself";
                    break;
                case 47:
                    magic = "You feel power well up within you, but with each spell you cast you feel the magic building up inside you waiting to explode. All spells you cast for the next minute deal double damage.When that minute is over, you take half of the damage you dealt during that minute.";
                    break;
                case 48:
                    magic = "A unicorn controlled by the DM appears in an unoccupied square within 5 ft.of you and disappears after 1 minute.";
                    break;
                case 49:
                    magic = "Flowers sprout from your ears and nose. They do not grow back once trimmed.";
                    break;
                case 50:
                    magic = "You can't speak for the next minute, when you try, pink bubbles float out of your mouth.";
                    break;
                case 51:
                    roll = DiceRoller.randInt(3, 30);
                    roll2 = DiceRoller.randInt(1, 6);
                    magic = roll + " gems leap forth from your mouth. Each one is worth " + roll2 + " gold pieces.";
                    break;
                case 52:
                    magic = "A spectral shield hovers near you for the next minute granting you a + 2 AC and immunity to magic missile.";
                    break;
                case 53:
                    magic = "You grow an extra limb. The limb dangles limply, occasionally mimicking the movement of other nearby limbs.The new limb sprouts from your shoulder in the case of an arm or his hip in the case of a leg but the DM decides which happens. The limb does not affect your equipment, provide additional attacks, or affect most in-game situations, but a DM might rule that the limb provides some circumstance penalties in social situations. This affliction can be removed with a Remove Curse spell or other similar magic.";
                    break;
                case 54:
                    roll = DiceRoller.randInt(5, 30);
                    magic = "You are immune to being intoxicated by alcohol for the next " + roll + " days.";
                    break;
                case 55:
                    magic = "You cast Earth Tremor at 4th level.";
                    break;
                case 56:
                    magic = "For the next minute, any flammable object you touch that isn't being worn or carried by another creature bursts into flame. ";
                    break;
                case 57:
                    roll = DiceRoller.randInt(1, 10);
                    magic = "You forget everything that happened in the last " + roll + " minutes.";
                    break;
                case 58:
                    magic = "The wild magic within you refills your spent arcane prowess. You regain your lowest level expended spell slot.";
                    break;
                case 59:
                    roll = DiceRoller.randInt(1, 4);
                    magic = "You are intoxicated (as if you drank far too much ale) for the next " + roll + " hours. Any penalties or benefits imposed are at the DM's discretion.";
                    break;
                case 60:
                    magic = "For the next minute you must shout when you speak.";
                    break;
                case 61:
                    magic = "A cloud appears over your head with a 10 foot radius. It snows over you for the next hour.";
                    break;
                case 62:
                    roll = DiceRoller.randInt(4, 24);
                    magic = "Up to 3 creatures within 30 ft. of you take " + roll + " lightning damage.";
                    break;
                case 63:
                    magic = " You cast Hypnotic Pattern centered on yourself. ";
                    break;
                case 64:
                    magic = "You are frightened by the nearest creature until the end of your next turn.";
                    break;
                case 65:
                    string[] hair = { "black", "brown", "blonde", "purple", "green", "white" };
                    string[] eyes = { "black", "white", "gold", "pink", "red", "rainbow" };
                    roll = DiceRoller.randInt(1, 5);
                    roll2 = DiceRoller.randInt(1, 5);
                    magic = "Your hair and eyes change colors, Your hair is " + hair[roll] + " and your eyes are " + eyes[roll2] + " This effect can be removed with a Remove Curse spell.";
                    break;
                case 66:
                    magic = "Each creature within 30 ft. of you becomes invisible for the next minute. The invisibility ends on a creature when it attacks or casts a spell. ";
                    break;
                case 67:
                    magic = "You feel a surge of wild magic within you that threatens to overwhelm you if not released. Double all dice damage for your next spell attack that hits.";
                    break;
                case 68:
                    roll = DiceRoller.randInt(1, 4);
                    magic = "A random creature within 60 ft. of you becomes poisoned for the next " + roll + " hours.";
                    break;
                case 69:
                    magic = "For a moment, you tap into the plane of Limbo and borrow raw chaotic power not your own. The next spell you cast (up to 4th level) does not expend a spell slot.";
                    break;
                case 70:
                    string[] animals = { "salmon", "cat", "frog", "rabbit", "dog", "raven", "mouse", "pig", "sheep", "bear" };
                    roll = DiceRoller.randInt(0, 9);
                    magic = "You cast Polymorph on yourself. If you fail the saving throw you turn into an " + animals[roll] + " for the duration. ";
                    break;
                case 71:
                    magic = "You take on the illusory visage of death himself. Every creature that can see you must make a Wisdom saving throw against your spell save DC or become frightened by you until the end of your next turn.";
                    break;
                case 72:
                    magic = "Illusory butterflies and flower petals flutter in the air within 10 ft. of you for the next minute";
                    break;
                case 73:
                    magic = "You cast Haste on yourself. ";
                    break;
                case 74:
                    magic = "You feel your innate magic quicken your movements. You can take one additional action immediately.";
                    break;
                case 75:
                    magic = "You cast Spider Climb on yourself. Your hands stick to any object that is not being worn or carried you touch for the duration of the spell";
                    break;
                case 76:
                    roll = DiceRoller.randInt(1, 10);
                    magic = "Each creature within 30 ft. of you takes 1d10 or " + roll + " necrotic damage. You regain hitpoints equal to the sum of the necrotic damage dealt.";
                    break;
                case 77:
                    magic = "For the next minute, your intelligence, wisdom, and charisma scores become 6(mod - 2) and your strength, dexterity and constitution scores become 20(mod + 5)";
                    break;
                case 78:
                    magic = "You cast Mirror Image.";
                    break;
                case 79:
                    magic = "You let out a thunderous belch. All creatures in a 15 ft. radius must make a Constitution saving throw against your spell save DC or be deafened.";
                    break;
                case 80:
                    magic = "You cast Fly on a random creature within 60 ft. of you.";
                    break;
                case 81:
                    roll = DiceRoller.randInt(1, 10);
                    roll2 = DiceRoller.randInt(1, 20);
                    int friend = 0;
                    int foe = 0;
                    for (int i = 0; i < roll; i++)
                    {
                        roll2 = DiceRoller.randInt(1, 20);
                        if (roll % 2 != 0)
                        {
                            foe++;
                        }
                        else
                        {
                            friend++;
                        }
                    }
                    magic = "You cast Animate Objects on " + roll + " random objects within the range that are not being worn or carried." + friend + " objects will take orders from and fight for you. " + foe + " object cannot be tamed and will fight whatever creature is nearest.";
                    break;
                case 82:
                    magic = "You become invisible for the next minute. During that time other creatures cannot hear you. The invisibility ends if you attack or cast a spell.";
                    break;
                case 83:
                    magic = "You cast Darkness centered on yourself.";
                    break;
                case 84:
                    magic = "You can see your lifeline before your eyes and for a moment you are emboldened because you know you will not die this day. If you die within the next minute you immediately come back to life as if by the Reincarnate spell.";
                    break;
                case 85:
                    //TODO add mephits
                    roll = DiceRoller.randInt(1, 4);
                    magic = roll + " Mephits chosen and controlled by the DM appear in unoccupied squares within 15 ft. of you.";
                    break;
                case 86:
                    magic = "Your size increases by one size category for the next minute.";
                    break;
                case 87:
                    magic = "You cast Sleep at 4th level centered on yourself.";
                    break;
                case 88:
                    magic = "The skin of you and everyone around you swells and inflates. You and all creatures within 30 ft. of you gain vulnerability to piercing damage for the next minute.";
                    break;
                case 89:
                    magic = "Next time you are hit by an attack within the next minute you cast Shield.";
                    break;
                case 90:
                    magic = "You are surrounded by faint ethereal music for the next minute.";
                    break;
                case 91:
                    magic = "You cast Web centered on yourself.";
                    break;
                case 92:
                    magic = "You feel for a moment as if a font of wild power lies within you. You regain all expended sorcery points.";
                    break;
                case 93:
                    //TODO Contagions
                    roll = DiceRoller.randInt(1, 6);
                    magic = "You cast Contagion on yourself. You rolled a " + roll + ". The effect spreads to any creature you touch before succeeding or failing the 3 saving throws.";
                    break;
                case 94:
                    magic = "Your hair falls out but grows back within 24 hours.";
                    break;
                case 95:
                    //TODO
                    magic = "Your hands glow with black necrotic energy. You cast Bestow Curse on the next creature you touch within 1 minute. The effect is chosen randomly with a 1d4 roll.";
                    break;
                case 96:
                    magic = "You cast Fog Cloud centered on yourself.";
                    break;
                case 97:
                    magic = "You cast Alter Self on yourself, growing claws, fangs, and horns as per the natural weapons portion of the spell.";
                    break;
                case 98:
                    magic = "Your magic bolsters your fortitude and for a moment you feel invincible. You gain resistance to all damage for the next minute.";
                    break;
                case 99:
                    magic = "You glow with bright light in a 30 ft. radius and dim light for another 30 ft. for the next minute. Any creature that ends its turn within 5 ft. of you is blinded until the end of its next turn.";
                    break;
                case 100:
                    magic = "You regain hitpoints, spell slots, hit dice, and sorcery points as if you had taken a long rest. Abilities from other classes are not regained in this way.";
                    break;

            }
            return magic;
        }

        public static string WorldEvent()
        {

            int dice = DiceRoller.randInt(1, 100);
            string localEvent = "";
            switch (dice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    localEvent = "Nothing Happens";
                    break;
                case 31: localEvent = "Assassination of a minor figure "; break;
                case 32: localEvent = "Assassination of a major figure "; break;
                case 33: localEvent = "Economic boom "; break;
                case 34: localEvent = "New Trade Route established "; break;
                case 35: localEvent = "Old Trade Route jeopardized"; break;
                case 36: localEvent = "Minor Pestilence"; break;
                case 37: localEvent = "Major Pestilence"; break;
                case 38: localEvent = "Drought"; break;
                case 39: localEvent = "Bumper Crop"; break;
                case 40: localEvent = "Rioting in a minor city"; break;
                case 41: localEvent = "Rioting in a major city"; break;
                case 42: localEvent = "Noble/ Important Birth"; break;
                case 43: localEvent = "Noble/Important Natural Death"; break;
                case 44: localEvent = "Economic Recession"; break;
                case 45: localEvent = "Pest infestation"; break;
                case 46: localEvent = "Fire in minor city"; break;
                case 47: localEvent = "Fire in major city"; break;
                case 48: localEvent = "Flood"; break;
                case 49: localEvent = "Important Shipwreck "; break;
                case 50: localEvent = "Important Marriage"; break;
                case 51: localEvent = "Minor Natural Disaster"; break;
                case 52: localEvent = "Major Natural Disaster"; break;
                case 53: localEvent = "Important Kidnapping"; break;
                case 54: localEvent = "Minor supernatural event"; break;
                case 55: localEvent = "Major supernatural event"; break;
                case 56: localEvent = "Religious schism "; break;
                case 57: localEvent = "Minor bandit raids"; break;
                case 58: localEvent = "Major bandit raids"; break;
                case 59: localEvent = "Astronomical event"; break;
                case 60: localEvent = "Minor heroic incident"; break;
                case 61: localEvent = "Major heroic incident"; break;
                case 62: localEvent = "Bard becomes slightly famous"; break;
                case 63: localEvent = "Bard becomes majorly famous"; break;
                case 64: localEvent = "Minor Thef"; break;
                case 65: localEvent = "Major Thef"; break;
                case 66: localEvent = "Minor Natural Disaster"; break;
                case 67: localEvent = "Major Natural Disaster"; break;
                case 68: localEvent = "Crime Wave"; break;
                case 69: localEvent = "Prophesy made"; break;
                case 70: localEvent = "Minor Monster Trouble"; break;
                case 71: localEvent = "Major Monster Trouble"; break;
                case 72: localEvent = "Minor Magical Item discovered/ created"; break;
                case 73: localEvent = "Major Magical Item discovered/ created"; break;
                case 74: localEvent = "Noble gains slight popularity"; break;
                case 75: localEvent = "Noble gains major popularity"; break;
                case 76: localEvent = "Small Civil War"; break;
                case 77: localEvent = "Large Civil War "; break;
                case 78: localEvent = "Incident causes racial tension "; break;
                case 79: localEvent = "Incident causes racial warfare"; break;
                case 80: localEvent = "Strife with a neighboring power"; break;
                case 81: localEvent = "Minor war "; break;
                case 82: localEvent = "Major war"; break;
                case 83: localEvent = "New civilized area founded"; break;
                case 84: localEvent = "Strife between religious sects"; break;
                case 85: localEvent = "War between religious sects"; break;
                case 86: localEvent = "New source of wealth discovered"; break;
                case 87: localEvent = "New religion founded"; break;
                case 88: localEvent = "Great book written"; break;
                case 89: localEvent = "Great work of art created"; break;
                case 90: localEvent = "Coup"; break;
                case 91: localEvent = "Event of justice (trial, etc.)"; break;
                case 92: localEvent = "Change in local laws"; break;
                case 93: localEvent = "Invention"; break;
                case 94: localEvent = "Guild grows powerful"; break;
                case 95: localEvent = "Extraplanar event"; break;
                case 96: localEvent = "Important discovery by explorers"; break;
                case 97: localEvent = "Academic advancement"; break;
                case 98: localEvent = "Religious event"; break;
                case 99: localEvent = "DM choice or event not listed"; break;
                case 100: localEvent = "Roll Twice"; break;

            }
            return localEvent;
        }

        public static String PiercingCrit()
        {
            int dice = DiceRoller.randInt(1, 20);
            string magic = "";
            switch (dice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    magic = "Double damage";
                    break;
                case 11:
                case 12:
                    magic = "Maximum Damage";
                    break;
                case 13:
                    magic = "Knee (x2 damage and can't move for one round)";
                    break;
                case 14:
                    magic = "Right Hand (x2 damage and hand is disabled until healed)";
                    break;
                case 15:
                    magic = "Left Hand (x2 damage and hand is disabled until healed)";
                    break;
                case 16:
                    magic = "Back (x2 damage and gain advantage on next attack)";
                    break;
                case 17:
                    magic = "Lung (x2 damage and 10 damage/round until healed)";
                    break;
                case 18:
                    magic = "Throat (x2 damage and can't speak until healed)";
                    break;
                case 19:
                    magic = "Heart (x3 damage)";
                    break;
                case 20:
                    magic = "Eye (x3 damage and blinded until healed)";
                    break;
            }
            return magic;
        }
        public static String BludgeoningCrit()
        {
            int dice = DiceRoller.randInt(1, 20);
            string magic = "";
            switch (dice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    magic = "Double damage";
                    break;
                case 11:
                case 12:
                    magic = "Maximum Damage";
                    break;
                case 13:
                    magic = "Leg (x2 damage and can't move for one round)";
                    break;
                case 14:
                    magic = "Right Arm (x2 damage and held item lands 10 feet away)";
                    break;
                case 15:
                    magic = "Left Arm (x2 damage and held item lands 10 feet away)";
                    break;
                case 16:
                    magic = "Torso (x2 damage and knocked back 5 feet)";
                    break;
                case 17:
                    magic = "Spine (x2 damage and stunned for one round)";
                    break;
                case 18:
                    magic = "Head - Side (x2 damage and deafened for one minute)";
                    break;
                case 19:
                    magic = "Head - Skullcap (x2 damage and knocked prone)";
                    break;
                case 20:
                    magic = "Head - Face (x3 damage, prone and stunned for one round)";
                    break;
            }
            return magic;
        }
        public static String SlashingCrit()
        {
            int dice = DiceRoller.randInt(1, 20);
            string magic = "";
            switch (dice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    magic = "Double damage";
                    break;
                case 11:
                case 12:
                    magic = "Maximum Damage";
                    break;
                case 13:
                    magic = "Leg (x2 damage and half movement until healed)";
                    break;
                case 14:
                    magic = "Right Arm (x2 damage and arm is disabled until healed)";
                    break;
                case 15:
                    magic = "Left Arm (x2 damage and arm is disabled until healed)";
                    break;
                case 16:
                    magic = "Chest (x2 damage and 5 damage/round until healed)";
                    break;
                case 17:
                    magic = "Gut (x2 damage and 10 damage/round until healed)";
                    break;
                case 18:
                    magic = "Head - Cheek (x2 damage and can't speak clearly until healed)";
                    break;
                case 19:
                    magic = "Head - Forehead (x2 damage and blinded for one round)";
                    break;
                case 20:
                    magic = "Head - Neck (x3 damage and free attack on adjacent foe if killed)";
                    break;
            }
            return magic;
        }
        public static String MagicCrit()
        {
            int dice = DiceRoller.randInt(1, 20);
            string magic = "";
            switch (dice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    magic = "Double damage";
                    break;
                case 11:
                case 12:
                    magic = "Maximum Damage";
                    break;
                case 13:
                    magic = "Seismic (x2 damage and enemy is knocked prone)";
                    break;
                case 14:
                    magic = " Maddening (x2 damage and enemy is frightened for one round)";
                    break;
                case 15:
                    magic = "Binding (x2 damage and enemy is restrained for one minute)";
                    break;
                case 16:
                    magic = "Vampiric (x2 damage and caster heals 10 HP)";
                    break;
                case 17:
                    magic = "Deafening (x2 damage and enemy is deafened for one minute)";
                    break;
                case 18:
                    magic = "Dazzling (x2 damage and blinded for one round)";
                    break;
                case 19:
                    magic = "Forked (x2 damage and copy hits another foe within 10 feet for 1x damage)";
                    break;
                case 20:
                    magic = "Effortless (x2 damage and spell is not expended) ";
                    break;
            }
            return magic;
        }
    }
}
