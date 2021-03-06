
/*
 * This file is autogenerated by the SqlToCSharp.cs tool. 
 * All modifications will be lost when the tool is ran.
 */ 


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;

#pragma warning disable 649

namespace MonkeyWrench.DataClasses
{
	public partial class DBLanefile : DBRecord
	{
		private string _name;
		private string _contents;
		private string _mime;
		private int? _original_id;
		private DateTime? _changed_date;
		private string _additional_roles;

		public string @name { get { return _name; } set { _name = value; } }
		public string @contents { get { return _contents; } set { _contents = value; } }
		public string @mime { get { return _mime; } set { _mime = value; } }
		public int? @original_id { get { return _original_id; } set { _original_id = value; } }
		public DateTime? @changed_date { get { return _changed_date; } set { _changed_date = value; } }
		public string @additional_roles { get { return _additional_roles; } set { _additional_roles = value; } }


		public override string Table
		{
			get { return "Lanefile"; }
		}
        

		public override string [] Fields
		{
			get
			{
				return new string [] { "name", "contents", "mime", "original_id", "changed_date", "additional_roles" };
			}
		}
        

	}
}

