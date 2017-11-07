using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootStrapExample.Models;

namespace BootStrapExample.Controllers
{
    public class HomeController : Controller
    {
        private static List<Character> getCharacters = GetCharacters();

        // GET: Home
        public ActionResult Index()
        {
            return View(getCharacters);
        }

        // GET: Home/Details/5
        public ActionResult ViewCharacter(int Id)
        {
            Character characterChoice = getCharacters[Id];
            return View("ViewCharacter", characterChoice);
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult CharacterForm()
        {
            return View("CreateCharacter");
        }

        // GET: Home/Create
        public ActionResult CreateCharacter(int Age, String Type, String Name, String Summary, String Mobility, String SpecialAttack, String Trivia)
        {
            string result;


            if (!(String.IsNullOrEmpty(Age.ToString()))) {
                if(!(string.IsNullOrEmpty(Type)))
                {
                    if(!(string.IsNullOrEmpty(Name)))
                    {
                        if(!(string.IsNullOrEmpty(Summary)))
                        {
                            if(!string.IsNullOrEmpty(Mobility))
                            {
                                if(!(string.IsNullOrEmpty(SpecialAttack)))
                                {
                                    if(!(string.IsNullOrEmpty(Trivia)))
                                    {
                                        getCharacters.Add(new Character(Age, Type, Name, Summary, Mobility, SpecialAttack, Trivia));
                                        result = "Complete";
                                    } else
                                    {
                                        result = "Trivia is not valid.";
                                    }
                                } else
                                {
                                    result = "Special is attack not valid.";
                                }
                            } else
                            {
                                result = "Mobility is not valid.";
                            }
                        } else
                        {
                            result = "Summary is not valid.";
                        }
                    } else
                    {
                        result = "Name is not valid.";
                    }
                } else
                {
                    result = "Type is not valid.";
                }
            } else
            {
                result = "Age is not valid.";
            }
            return View("Results", result);
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static List<Character> GetCharacters()
        {
            return new List<Character>
             {
                 new Character { Id = 1,
                     Age = 5,
                     Type = "Robot",
                     Name = "Switch",
                     Summary = "Switch is a skateboarding ex-working class robot. He uses his skateboard and skateboard tricks to hit the ball. He sports cargo pants to stop filth getting into his leg joints when speeding across the city. Very unlike his old robot peers, he’s carefree, a daredevil, and he likes a challenge.",
                     Mobility = "Switch can wall-ride by jumping at the wall. He can hold this wall-ride until he either lets go or reaches the opposite upper corner.",
                     SpecialAttack = "This special in its raw form, when one uses a jump input whilst midair to hit the ball, has little hitlag at any ball speed. When used during hitlag it launches the ball at a predetermined shallow angle, which can be only manipulated by changing the launch direction to either left or right. Use of this special during his smash is sometimes known as a 'Quickflip' and is made more effective with use of a bunt, significantly reducing hitlag. Like many other specials, no additional hitlag is generated when using his special in this way. This means it's much more beneficial to use his overhead special at the end of hitlag rather than the beginning.",
                     Trivia = "His name is Switch because he rides Switch on his skateboard, and not the fact that he is a robot.(switch means a skater puts their lead foot on the back and back foot in the front 'switching around' their foot placement"
                 },
                  new Character { Id = 2,
                     Age = 15,
                     Type = "Human",
                     Name = "Raptor",
                     Summary = "Raptor is a rookie in the Lethal League scene, hailing from the south. Though young, he’s very determined and fiercely competitive. His weapon of choice is a metal baseball bat and his special ability allows him to twist around and quickly hit the ball two times in a row.",
                     Mobility = "Raptor can wall-jump by jumping into the wall and jumping again. He can also wall-slide by pressing against the wall. The wall-slide is lost if he touches the floor.",
                     SpecialAttack = "After hitting the ball, Raptor can either hit the ball again in one of six angles, plus a bonus smash angle when grounded; or bunt it. The timing of this ability can be altered by holding down the button for varying lengths of time, and if it's held for the longest possible time, the ball's speed will be doubled like a smash. Using this ability resets the hitlag timer, so it can be used at the very beginning of hitlag to shorten it or used at the very end to lengthen it. ",
                     Trivia = "Raptor likely got his namesake from the Velociraptor dinosaur, or one of the unofficial names for birds of prey, the raptor. 'Because he is viciously competitive'"
                 },
                  new Character { Id = 3,
                     Age = 28,
                     Type = "Mutated Human",
                     Name = "Candyman",
                     Summary = "Candyman is a tap-dancing dandy with a big yellow head. He hits the ball with his cane and he has a special ability to change the chemical composition of certain objects to give them strange and odd properties due to his mutation. He’s jazzy, expressive and crazy. Always enjoying himself too.",
                     Mobility = "Candyman's special movement ability is slightly less advanced than the other characters. Rather than activating some method of reaching the top of the stage, his jumps are naturally higher than the other characters. This also limits his ability to short-hop.",
                     SpecialAttack = "Candyman changes the properties of the ball for a brief period of time, allowing it to phase through walls by pressing melee during hitlag. If it hits a wall it will show up on the other wall, if it hits the floor/ceiling it will go to the opposite side. If Candy hits the ball while it can still teleport the special move is drawn out longer (doesn't require more meter) which could be used to further manipulate the ball and allow it to continue to pass through walls. It should also be noted that when Candyman hits his own candyball, it will result in significantly shorter hitlag while still only giving him one bar of super meter per hit. It is possible that the Candyman can keep his special going forever, as long as he continues to hit the ball.",
                     Trivia = "In a Christmas update, Candyman is shown wearing a Santa-like costume. He dons a red Santa Hat and Green suit. Yet, his cane retains its normal appearance."
                  },
             };
        }

    }
}
