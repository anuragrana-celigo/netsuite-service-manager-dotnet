//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchColumnBooleanCustomField 
		: ISupportSearchValue< Boolean? >
	{ 
		public Boolean? GetSearchValue()
		{
			if (!this.searchValueFieldSpecified)
			{
				return null;
			}
			return this.searchValue;
		}
		
				
		public void SetSearchValue(Boolean? value)
		{
			this.searchValue = value.GetValueOrDefault();
			this.searchValueSpecified = (null != value && value.HasValue); 			
		}
		
				
	}
}
