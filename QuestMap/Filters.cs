using Lumina.Excel.GeneratedSheets;
using System.Collections.Generic;
using System.Linq;

namespace QuestMap
{
    internal class Filters
    {
        private Plugin Plugin;

        private List<IFiltered> FilterConditions { get; } = new List<IFiltered> {
            // starting city questlines
            new OneQuestOf(65_575, 65_643, 66_130), // Coming to [starting city]
            new OneQuestOf(65_621, 65_644, 65_645, 65_659, 65_660, 66_104, 66_105, 66_106), // Close to Home (one per starting class)
            #region Gridania
            new ConditionalQuests(
                65_575, // Coming to Gridania

                // MSQ
                65_564, // To the Bannock
                65_737, // Passing Muster
                65_981, // Chasing Shadows
                65_664, // Eggs over Queasy (old)
                69_390, // Eggs over Queasy
                65_711, // Surveying the Damage
                65_734, // Butcher of Greentear (removed)
                65_661, // A Soldier's Breakfast (old)
                69_391, // A Soldier's Breakfast
                65_665, // Spirithold Broken
                65_712, // On the Bentbranch
                65_912, // You Shall Not Trespass
                65_913, // Don't Look Down
                65_915, // In the Grim Darkness of the Forest
                65_916, // Threat Level Elevated
                65_917, // Migrant Marauders
                65_920, // A Hearer Is Often Late
                65_923, // Salvaging the Scene
                65_697, // Leia's Legacy
                65_982, // Dread is in the Air
                65_983, // To Guard a Guardian
                65_984, // Festive Endeavors
                65_985, // Renewing the Covenant
                66_043, // The Gridanian Envoy
                66_210, // Call of the Sea, used in both Gridania & Limsa
                
                // side quests
                65_756, // Leves of Bentbranch
                65_596, // Simply the Hest
                65_537, // A Good Adventurer is Hard to Find
                65_573, // Population Control
                65_568, // A Hard Nut to Crack
                65_570, // Derision of Labor
                65_732, // An Eft for Effort
                65_708, // More than a Flesh Wound
                65_663, // Parasite Cleave
                65_666, // Soil Despoilers
                65_914 // Look, but Won't Touch

                // This may not be a complete list, my main char is from Gridania so this doesn't matter much to me
            ),
            new ReplacedQuest(65_664, 69_390), // Eggs over Queasy
            new ReplacedQuest(65_661, 69_391), // A Soldier's Breakfast
            new UnobtainableQuest(66_964), // He's Got a Ticket to Ride
            new UnobtainableQuest(65_734), // Butcher of Greentear
            new UnobtainableQuest(65_910), // Feeding Time
            new UnobtainableQuest(65_692), // Ruffled Feathers
            new UnobtainableQuest(65_918), // Skeletons in My Deepcroft
            new UnobtainableQuest(65_695), // Lights Out
            #endregion Gridania

            #region Limsa
            new ConditionalQuests(
                65_643, // Coming to Limsa Lominsa

                // MSQ
                65_998, // On to Summerford
                65_999, // Dressed to Call
                66_079, // Lurkers in the Grotto
                66_001, // Washed Up
                66_002, // Double Dealing
                66_003, // Loam Maintenance
                66_004, // Plowshares to Swords
                66_005, // Just Deserts
                65_933, // Sky-high
                65_938, // Thanks a Million
                65_939, // Relighting the Torch
                65_942, // On the Drydocks
                65_948, // Without a Doubt
                65_951, // Righting the Shipwright
                65_949, // Do Angry Pirates Dream
                65_950, // Victory in Peril
                66_225, // Men of the Blue Tattoos
                66_080, // Feint and Strike
                66_226, // High Society
                66_081, // A Mizzenmast Repast
                66_082, // The Lominsan Envoy
                66_210, // Call of the Sea, used in both Gridania & Limsa

                // side quests
                66_229, // Leves of Swiftperch
                65_595, // Simply the Hest
                65_647, // Making a Name
                65_648, // Suspiciously Sober
                65_658, // Glory Days
                66_199, // Fool Me Once
                66_008, // The Time Is Ripe
                66_009, // Orange Crush
                66_000, // Further Afield
                66_006, // Yarzon, Yarzoff
                66_001, // Washed Up,
                66_002, // Double Dealing
                66_010, // A Pound of Cure
                66_023, // Meet, Greet, and Deceit
                65_936, // Keeping it Fresh
                65_937, // Baiting Buzzards
                65_940, // Farmer of Fortune
                65_941, // Need to Breed
                66_011, // Cry Me a Liver
                66_012, // Wool's Errand
                66_013, // Flour Power
                66_014, // Kobolds and Ingredients
                66_015, // Bait and Swat
                66_022 // Kobolds Ahoy

            ),
            new UnobtainableQuest(65_934), // Courier for a Day
            #endregion Limsa

            #region Ul'dah
            new ConditionalQuests(
                66_130, // Coming to Ul'dah

                // MSQ
                66_131, // We Must Rebuild
                66_207, // Nothing to See Here
                66_086, // Underneath the Sultantree
                65_839, // Step Nine
                65_842, // Prudence at this Junction (old)
                69_388, // Prudence at this Junction
                65_843, // Out of House and Home
                65_856, // Way Down in the Hole
                66_159, // Takin' What They're Givin'
                65_864, // Supply & Demand
                66_039, // Give It to Me Raw
                65_865, // The Perfect Swarm
                65_866, // The Letter to Lost Hope
                65_867, // Heir Today, Gone Tomorrow (old)
                69_389, // Heir Today, Gone Tomorrow
                65_868, // Passing the Blade
                65_869, // Following Footfalls
                65_870, // Storms on the Horizon
                65_872, // Oh Captain, My Captain
                66_164, // Secrets and Lies
                66_087, // Duty, Honor, Country
                66_177, // A Matter of Tradition
                66_088, // A Royal Reception
                66_064, // The Ul'dahn Envoy
                66_209, // Call of the Sea, used only in Ul'dah

                // side quests
                66_223, // Leves of Horizon
                65_594, // Simply the Hest
                65_857, // The Slaying of the Shrews
                65_858, // Listen to Your Fish
                65_840, // The Tasting of the Shrews
                65_862, // Sometimes the Old Ways Are Best
                65_844, // In the Court of the Rat King
                65_877, // The Scent of a Mongrel
                65_878, // Lominsan Rubbish
                65_924, // Bloodied and Bowed
                65_925, // Fantastic Voyage
                65_926, // Catch Your Breath
                66_040, // No Tool Gets Left Behind
                66_041, // Angling Ankle-Biters
                66_042, // This Fishwife's Life
                66_066, // Alternative Medicine
                66_067, // Need Not Apply in Person
                66_109 // Fringe Benefits
            ),
            new UnobtainableQuest(65_860), // Disorderly Conduct
            new UnobtainableQuest(65_841), // Until a Quieter Time
            new UnobtainableQuest(65_863), // Spriggan Cleaning
            new UnobtainableQuest(65_871), // Compulsory Catering
            new UnobtainableQuest(66_965), // Lend Me Your Ears Already
            new ReplacedQuest(65_842, 69_388), // Prudence at this Junction
            new ReplacedQuest(65_867, 69_389), // Heir Today, Gone Tomorrow
            #endregion Ul'dah

            // Grand Company specific quests - can only complete them for one GC, even if you switch later
            // Shadows Uncast & Gilding the Bilbious can be done once per GC, so they're not exclusive
            new OneQuestOf(66_216, 66_217, 66_218), // The Company You Keep
            new OneQuestOf(66_219, 66_220, 66_221), // The Company You Keep follow-up quest
            new OneQuestOf(66_236, 66_237, 66_238), // My Little Chocobo
            new OneQuestOf(66_640, 66_641, 66_642), // A Pup No Longer
            new OneQuestOf(67_001, 67_002, 67_003), // Call of the Wild
            new OneQuestOf(67_063, 67_064, 67_065), // Like Civilized Men and Women
            new OneQuestOf(67_099, 67_100, 67_101), // Let the Hunt Begin
            new OneQuestOf(67_925, 67_926, 67_927), // Squadron and Commander

            // class quests: depending on whether or not it's your starting class, you get a different quest
            // Format: ([quest id if this was your starting class], [so you want to be a lancer], [way of the lancer, if picked up later], [your first spear])
            new StartingJobQuest(65_557, 65_717, 65_667, 65_755), // ARC
            new StartingJobQuest(65_558, 65_718, 65_669, 65_747), // CNJ // seems odd that the replaced if for CNJ & LNC aren't the same order as the original ids
            new StartingJobQuest(65_559, 65_716, 65_668, 65_754), // LNC
            new StartingJobQuest(65_789, 65_713, 65_821, 65_822), // GLA
            new StartingJobQuest(65_847, 65_715, 65_846, 65_848), // MRD
            new StartingJobQuest(65_881, 65_719, 65_880, 65_882), // THM
            new StartingJobQuest(65_989, 65_987, 65_988, 65_990), // ACN
            new StartingJobQuest(66_069, 65_714, 66_068, 66_089), // PGL

            // duplicate quests - unsure what happened to those, as the quest ids are very close; might be dependent on your starting job/city but isn't a thing for all classes
            new OneQuestOf(65_571, 65_679), // LNC: Courage of Stone
            new OneQuestOf(65_850, 65_851), // MRD: Wake of Destruction
            new OneQuestOf(65_884, 65_885), // THM: The Threat of Paucity
            new OneQuestOf(65_992, 65_993), // ACN: Tactical Planning
            new OneQuestOf(65_797, 65_824), // GLA: Ul'dah's Most Wanted, large id difference
            new OneQuestOf(66_091, 66_234), // PGL: Burning Up the Quarter Malm
            
            // quest choices
            new OneQuestOf(66_968, 66_969, 66_970), // An Ill-conceived Venture
            new OneQuestOf(69_256, 69_257), // NieR: Tails, You Lose -- Heads, I Win
            new OneQuestOf(69_336, 69_337), // Qitari: First Stela
            new OneQuestOf(69_338, 69_339), // Qitari: Second Stela
            new OneQuestOf(69_340, 69_341), // Qitari: Third Stela
            new IslandSanctuaryQuest(),

            // Ishgard Restoration, I think this was something to do with interacting with the board when the relvant stage was finished
            // These aren't in the journal, and they don't have any wiki pages either. As of 6.28, none of them seems obtainable.
            new UnobtainableQuest(69_296), // The Mendicant's Court
            new UnobtainableQuest(69_377), // The New Nest
            new UnobtainableQuest(69_508), // Featherfall
            new UnobtainableQuest(69_578), // The Risensong Quarter

            // updated quests
            new ReplacedQuest(65_603, 65_670), // BRD: School of Hard Nooks -> Training with Leih
            new ReplacedQuest(65_627, 65_683), // WHM: Trial by Wind
            new ReplacedQuest(66_957, 68_553), // Glamour unlock
            new ReplacedQuest(66_958, 68_554), // Glamour prism crafting
            new ReplacedQuest(66_097, 67_823), // ARR Relics: The Vital Title
            new UnobtainableQuest(67_819), // A Seat at the Feast
        };

        public Filters(Plugin plugin)
        {
            Plugin = plugin;
        }

        public bool IsObtainable(Quest quest)
        {
            if (Plugin.Common.Functions.Journal.IsQuestCompleted(quest))
                return true;

            if (FilterConditions.Any(f => f.IsUnobtainable(Plugin, quest.RowId)))
                return false;

            return true;
        }

        internal interface IFiltered
        {
            bool IsUnobtainable(Plugin plugin, uint quest);
        }

        internal class OneQuestOf : IFiltered
        {
            public List<uint> QuestIds { get; }

            public OneQuestOf(params uint[] questIds)
            {
                QuestIds = questIds.ToList();
            }

            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                return QuestIds.Contains(quest) && QuestIds.Any(plugin.Common.Functions.Journal.IsQuestCompleted);
            }
        }

        internal class ReplacedQuest : IFiltered
        {
            public uint OriginalQuestId { get; }
            public uint NewQuestId { get; }

            public ReplacedQuest(uint originalQuestId, uint newQuestId)
            {
                OriginalQuestId = originalQuestId;
                NewQuestId = newQuestId;
            }

            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                return quest == OriginalQuestId || (quest == NewQuestId && plugin.Common.Functions.Journal.IsQuestCompleted(OriginalQuestId));
            }
        }

        internal class ConditionalQuests : IFiltered
        {
            public uint RequiredQuest { get; }
            public List<uint> FollowUpQuests { get; }

            public ConditionalQuests(uint requiredQuest, params uint[] followUpQuestIds)
            {
                RequiredQuest = requiredQuest;
                FollowUpQuests = followUpQuestIds.ToList();
            }

            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                if (plugin.Common.Functions.Journal.IsQuestCompleted(RequiredQuest))
                    return false;

                return FollowUpQuests.Contains(quest);
            }
        }

        internal class StartingJobQuest : IFiltered
        {
            public uint StartingClassQuestId;
            public List<uint> LaterClassQuestIds;

            public StartingJobQuest(uint wayOfTheMsqQuestId, uint soYouWantToBeAQuestId, uint wayOfTheSideQuestId, uint myFirstWeaponQuestId)
            {
                StartingClassQuestId = wayOfTheMsqQuestId;
                LaterClassQuestIds = new List<uint> { soYouWantToBeAQuestId, wayOfTheSideQuestId, myFirstWeaponQuestId };
            }

            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                if (plugin.Common.Functions.Journal.IsQuestCompleted(StartingClassQuestId))
                    return LaterClassQuestIds.Contains(quest);
                else
                    return quest == StartingClassQuestId;
            }
        }

        internal class UnobtainableQuest : IFiltered
        {
            public uint QuestId { get; }

            public UnobtainableQuest(uint questId)
            {
                this.QuestId = questId;
            }

            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                return quest == QuestId;
            }
        }

        internal class IslandSanctuaryQuest : IFiltered
        {
            // Seeing the Cieldalaes doesn't seem to be available after unlocking the Island Sanctuary
            // - Seeking the Cieldalaes is unlockable after the Praetorium
            // - Seeking Sanctuary is unlockable after 6.0
            public bool IsUnobtainable(Plugin plugin, uint quest)
            {
                return quest == 70_180 && plugin.Common.Functions.Journal.IsQuestCompleted(70_179);
            }
        }
    }
}
