﻿//~ Generated by ISupportSearchValueNTemplate.tt
#if !FIRSTBUILD
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchMultiSelectField 
		: ISupportSearchValue< RecordRef[] > ,  
			ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchMultiSelectFieldOperator > 
	{ 
		public RecordRef[] GetSearchValue()
		{
			return this.searchValue;
		}
		
				
		public void SetSearchValue(RecordRef[] value)
		{
			this.searchValue = value; 			
		}
		
				
	}
}
#endif
