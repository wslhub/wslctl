using System;

namespace wslctl.Models
{
    public sealed class Verb
    {
        public Verb(string name, string displayName, string description, string synopsis)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            
            if (string.IsNullOrWhiteSpace(displayName))
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException(nameof(description));
            }
            
            Name = name;
            DisplayName = displayName;
            Description = description;
            Synopsis = (synopsis ?? string.Empty).Trim();
        }
        
        public string Name { get; private set; }
        
        public string DisplayName { get; private set; }
        
        public string Description { get; private set; }
        
        public string Synopsis { get; private set; }

        public override string ToString()
        {
            return $"--{Name}: {DisplayName} {Description}";
        }
    }
}
