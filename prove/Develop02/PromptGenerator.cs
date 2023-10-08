using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

public class PromptGenerator
{
    
    // Creating a list of prompts (Attribute).
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "Have I done anything lately that is worth remembering?", "What kind of day am I having, and why?", "What was the most challenging thing I faced today?", "What am I grateful for today?", "What was the most fun thing I did today?", "Write about an experience that taught you a valuable lesson about forgiveness or acceptance.", "What are my top priorities for the day?", "What are three things that I could have done differently today, and how can I learn from these experiences?", "What did I accomplish today?", "What did I do to relax and recharge today?", "What am I looking forward to tomorrow?"};
    
    // Random object 
    Random opt = new Random(); 
    
   // GetPropmt method.
   public string GetPrompt() 
   {
        int index = opt.Next(_prompts.Count());
        return _prompts[index];
   }

}