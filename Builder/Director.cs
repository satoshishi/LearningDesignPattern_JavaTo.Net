using System.Collections;
using System.Collections.Generic;

namespace Builder
{
    public class Director
    {
        private LogBuilder builder;

        public Director(LogBuilder builder)
        {
            this.builder = builder;
        }

        public void Handle(User user)
        {
            builder.Handle(user);
        }
    }
}