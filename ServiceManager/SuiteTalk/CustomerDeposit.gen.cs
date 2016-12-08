﻿//~ Generated by RecordTemplate.tt
#if !FIRSTBUILD
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class CustomerDeposit : ISupportsCustomFields<CustomFieldRef>
	{
		/// <summary>
		/// Gets the Internal ID.
		/// </summary>
		/// <returns>The Internal ID of the record.</returns>
		public override string GetInternalId()
		{
			return this.internalIdField;
		}

		/// <summary>
		/// Sets the Internal ID.
		/// </summary>
		/// <param name="id">The Internal ID.</param>
		public override void SetInternalId(string id)
		{
			this.internalIdField = id;
		}
			
		/// <summary>
		/// Gets custom field with the given ID or <c>null</c> if a field with the
		/// given ID was not found.
		/// </summary>
		public T FindCustomField<T>(string fieldId) where T: CustomFieldRef
		{
			T match = null;
			if (null != this.customFieldList)
			{
				match = (T)Array.Find(
									this.customFieldList, 
									f => f is T && f.GetInternalId() == fieldId);
			}				
			return match;
		}
			
        /// <summary>
        /// Gets custom field with the given ID or <c>null</c> if a field with the
        /// given ID was not found.
        /// </summary>
        public CustomFieldRef FindCustomField(string fieldId)
		{
			CustomFieldRef match = null;
			if (null != this.customFieldList)
			{
				match = Array.Find(
									this.customFieldList, 
									f => f.GetInternalId() == fieldId);
			}				
			return match;
		}
	}
}
#endif
