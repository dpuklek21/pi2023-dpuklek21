﻿using System;

internal class Perosn
{
	public abstract class Perosn : object

	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() {
            return FirstName + " " + LastName;
        }

    }
}
