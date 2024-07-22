using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    // Create a Singleton - similar to Text class
    // There can only be ONE class that executes the Actions
    // "sealed" - unmodifiable

    public sealed class Actions
    {
        private static Actions _instance;

        public static Actions Instance
        {  
            get 
            { 
                if (_instance == null)
                    _instance = new Actions();

                return _instance; 
            } 
        }

        // Dictionary to contain a Collection of each of the actions that we register w/the Actions class
        //    - readonly b/c we don't want to modify this dictionary outside the class itself
        // Key:    string
        // Action: value
        private readonly Dictionary<string, Action> _registeredActions = new();

        // private constructor that's going to ensure there's no way to create 
        // an instance of the Actions class outside of the Instance instansiator 
        private Actions()
        {

        }

        // Register actions and execute them when the player uses one
        public void Register(Action action)
        {
            var name = action.Name.ToLower();

            if(_registeredActions.ContainsKey(name) )
            {
                _registeredActions[name] = action;
            }
            else
            {
                _registeredActions.Add(name, action);
            }
        }

        public void Execute(string[] args)
        {
            // assume first argument is an action
            var actionName = args[0];
            if (_registeredActions.ContainsKey(actionName) )
            {
                _registeredActions[actionName].Execute(args);
            }
            else
            {
                Console.WriteLine(Text.Language.ActionError);
            }
        }
    }

}
