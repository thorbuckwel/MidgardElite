using Engine.Session;
using System;

namespace MidgardElite.Commands
{
    public class PlayerInput
    {
        private static void ParseInput(string input)
        {
            if (input.Contains("help") || input == "?")
            {
                Console.WriteLine("Available commands");
                Console.WriteLine("====================================");
                Console.WriteLine("Stats - Display player information");
                Console.WriteLine("Look - Get the description of your location");
                Console.WriteLine("Inventory - Display your inventory");
                Console.WriteLine("Quests - Display your quests");
                Console.WriteLine("Attack - Fight the monster");
                Console.WriteLine("Equip <weapon name> - Set your current weapon");
                Console.WriteLine("Drink <potion name> - Drink a potion");
                Console.WriteLine("Trade - display your inventory and vendor's inventory");
                Console.WriteLine("Buy <item name> - Buy an item from a vendor");
                Console.WriteLine("Sell <item name> - Sell an item to a vendor");
                Console.WriteLine("North - Move North");
                Console.WriteLine("South - Move South");
                Console.WriteLine("East - Move East");
                Console.WriteLine("West - Move West");
                Console.WriteLine("Exit - Save the game and exit");
            }
            else if (input == "stats")
            {
                Score.Stats(GameSession.CurrentPlayer);
            }
            else if (input == "look")
            {
                Look.Looking();
            }
            else if (input.Contains("north"))
            {
                //GameSession.HasLocationToNorth;
            }
            //else if (input.Contains("east"))
            //{
            //    if (_player.CurrentLocation.LocationToEast == null)
            //    {
            //        Console.WriteLine("You cannot move East");
            //    }
            //    else
            //    {
            //        _player.MoveEast();
            //    }
            //}
            //else if (input.Contains("south"))
            //{
            //    if (_player.CurrentLocation.LocationToSouth == null)
            //    {
            //        Console.WriteLine("You cannot move South");
            //    }
            //    else
            //    {
            //        _player.MoveSouth();
            //    }
            //}
            //else if (input.Contains("west"))
            //{
            //    if (_player.CurrentLocation.LocationToWest == null)
            //    {
            //        Console.WriteLine("You cannot move West");
            //    }
            //    else
            //    {
            //        _player.MoveWest();
            //    }
            //}
            //else if (input == "inventory")
            //{
            //    foreach (InventoryItem inventoryItem in _player.Inventory)
            //    {
            //        Console.WriteLine("{0}: {1}", inventoryItem.Description, inventoryItem.Quantity);
            //    }
            //}
            //else if (input == "quests")
            //{
            //    if (_player.Quests.Count == 0)
            //    {
            //        Console.WriteLine("You do not have any quests");
            //    }
            //    else
            //    {
            //        foreach (PlayerQuest playerQuest in _player.Quests)
            //        {
            //            Console.WriteLine("{0}: {1}", playerQuest.Name,
            //                playerQuest.IsCompleted ? "Completed" : "Incomplete");
            //        }
            //    }
            //}
            //else if (input.Contains("attack"))
            //{
            //    if (_player.CurrentLocation.MonsterLivingHere == null)
            //    {
            //        Console.WriteLine("There is nothing here to attack");
            //    }
            //    else
            //    {
            //        if (_player.CurrentWeapon == null)
            //        {
            //            // Select the first weapon in the player's inventory 
            //            // (or 'null', if they do not have any weapons)
            //            _player.CurrentWeapon = _player.Weapons.FirstOrDefault();
            //        }

            //        if (_player.CurrentWeapon == null)
            //        {
            //            Console.WriteLine("You do not have any weapons");
            //        }
            //        else
            //        {
            //            _player.UseWeapon(_player.CurrentWeapon);
            //        }
            //    }
            //}
            //else if (input.StartsWith("equip "))
            //{
            //    string inputWeaponName = input.Substring(6).Trim();

            //    if (string.IsNullOrEmpty(inputWeaponName))
            //    {
            //        Console.WriteLine("You must enter the name of the weapon to equip");
            //    }
            //    else
            //    {
            //        Weapon weaponToEquip =
            //            _player.Weapons.SingleOrDefault(
            //                x => x.Name.ToLower() == inputWeaponName || x.NamePlural.ToLower() == inputWeaponName);

            //        if (weaponToEquip == null)
            //        {
            //            Console.WriteLine("You do not have the weapon: {0}", inputWeaponName);
            //        }
            //        else
            //        {
            //            _player.CurrentWeapon = weaponToEquip;

            //            Console.WriteLine("You equip your {0}", _player.CurrentWeapon.Name);
            //        }
            //    }
            //}
            //else if (input.StartsWith("drink "))
            //{
            //    string inputPotionName = input.Substring(6).Trim();

            //    if (string.IsNullOrEmpty(inputPotionName))
            //    {
            //        Console.WriteLine("You must enter the name of the potion to drink");
            //    }
            //    else
            //    {
            //        HealingPotion potionToDrink =
            //            _player.Potions.SingleOrDefault(
            //                x => x.Name.ToLower() == inputPotionName || x.NamePlural.ToLower() == inputPotionName);

            //        if (potionToDrink == null)
            //        {
            //            Console.WriteLine("You do not have the potion: {0}", inputPotionName);
            //        }
            //        else
            //        {
            //            _player.UsePotion(potionToDrink);
            //        }
            //    }
            //}
            //else if (input == "trade")
            //{
            //    if (_player.CurrentLocation.VendorWorkingHere == null)
            //    {
            //        Console.WriteLine("There is no vendor here");
            //    }
            //    else
            //    {
            //        Console.WriteLine("PLAYER INVENTORY");
            //        Console.WriteLine("================");

            //        if (_player.Inventory.Count(x => x.Price != World.UNSELLABLE_ITEM_PRICE) == 0)
            //        {
            //            Console.WriteLine("You do not have any inventory");
            //        }
            //        else
            //        {
            //            foreach (
            //                InventoryItem inventoryItem in _player.Inventory.Where(x => x.Price != World.UNSELLABLE_ITEM_PRICE))
            //            {
            //                Console.WriteLine("{0} {1} Price: {2}", inventoryItem.Quantity, inventoryItem.Description,
            //                    inventoryItem.Price);
            //            }
            //        }

            //        Console.WriteLine("");
            //        Console.WriteLine("VENDOR INVENTORY");
            //        Console.WriteLine("================");

            //        if (_player.CurrentLocation.VendorWorkingHere.Inventory.Count == 0)
            //        {
            //            Console.WriteLine("The vendor does not have any inventory");
            //        }
            //        else
            //        {
            //            foreach (InventoryItem inventoryItem in _player.CurrentLocation.VendorWorkingHere.Inventory)
            //            {
            //                Console.WriteLine("{0} {1} Price: {2}", inventoryItem.Quantity, inventoryItem.Description,
            //                    inventoryItem.Price);
            //            }
            //        }
            //    }
            //}
            //else if (input.StartsWith("buy "))
            //{
            //    if (_player.CurrentLocation.VendorWorkingHere == null)
            //    {
            //        Console.WriteLine("There is no vendor at this location");
            //    }
            //    else
            //    {
            //        string itemName = input.Substring(4).Trim();

            //        if (string.IsNullOrEmpty(itemName))
            //        {
            //            Console.WriteLine("You must enter the name of the item to buy");
            //        }
            //        else
            //        {
            //            // Get the InventoryItem from the trader's inventory
            //            InventoryItem itemToBuy =
            //                _player.CurrentLocation.VendorWorkingHere.Inventory.SingleOrDefault(
            //                    x => x.Details.Name.ToLower() == itemName);

            //            // Check if the vendor has the item
            //            if (itemToBuy == null)
            //            {
            //                Console.WriteLine("The vendor does not have any {0}", itemName);
            //            }
            //            else
            //            {
            //                // Check if the player has enough gold to buy the item
            //                if (_player.Gold < itemToBuy.Price)
            //                {
            //                    Console.WriteLine("You do not have enough gold to buy a {0}", itemToBuy.Description);
            //                }
            //                else
            //                {
            //                    // Success! Buy the item
            //                    _player.AddItemToInventory(itemToBuy.Details);
            //                    _player.Gold -= itemToBuy.Price;

            //                    Console.WriteLine("You bought one {0} for {1} gold", itemToBuy.Details.Name, itemToBuy.Price);
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
