﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FasTnT.Persistence.Dapper {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FasTnT.Persistence.Dapper.SqlRequests", typeof(SqlRequests).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H4sIAAAAAAAA/81aXU/jOBR9pr/CQrOiXRUEzKy0GjQPIXVLlpB08gHLUxQaF6JJkxAnzLK/fm8ct803oc2I5aHQ+Pr6+pxz7WuH42OE56KkI128wjfCQNSwYGD+DUlTpKgGwn9LuqEjEi5cerE2MYRLGddZnETkOSE0HgwHCH5cByUJfKRmiinLY/bUCRbJivixFbsrgtIPGturEP1046cgidkT9G/gk1K/iCyCyOneC03wVDBlgzWlLcMj0xCPvn6NyT/xGPnBz+FolLlOKIksHm32hCYPdBG5YewGftqyeLIjexGTCL3Y0avrPw7Pzv8cIVGV5RSR8NFa2LHtBY8nhw5Z2okXH2aORFXRDU2QFAMdzq8tDtAhmmvSjaDdo2t8j4auMxqMBneScYWGqjTR0Tc0FWQdjzpATl4Ylq8h2aJOV7bnuX5cQtC3AaPqTM7/aJ9IyYtLLYeEwIYdEwc9BIFHbL+K+tL2KKnFYBtx3zC06o5DbzW1vk9dWS8A [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateDatabaseZipped {
            get {
                return ResourceManager.GetString("CreateDatabaseZipped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H4sIAAAAAAAA/3MJ8g9QCHb2cPV1VPB0U3CN8AwOCVYoLk0qTi7KLCjJzM8rVnB2DHZ2dHG15nLBqjg5qYyQktSC5EyC5iSWpmSWEFJUWpxahG6SW6ifc4invx8uD+iVFqQklqTGowhaAwD9IG4I+gAAAA==.
        /// </summary>
        internal static string DropDatabaseZipped {
            get {
                return ResourceManager.GetString("DropDatabaseZipped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT request.record_time as capture_time, event.id, event_type as type, event.record_time as event_time, action, read_point, event_timezone_offset, disposition, business_location, business_step, transformation_id, event_id FROM epcis.event JOIN epcis.request on request.id = event.request_id /**where**/ /**orderby**/ LIMIT @limit.
        /// </summary>
        internal static string EventQuery {
            get {
                return ResourceManager.GetString("EventQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.attribute(masterdata_id, masterdata_type, id, value) VALUES(@ParentId, @ParentType, @Id, @Value) ON CONFLICT ON CONSTRAINT pk_cbv_masterdata_attribute DO UPDATE SET value = @Value;.
        /// </summary>
        internal static string MasterDataAttributeInsert {
            get {
                return ResourceManager.GetString("MasterDataAttributeInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.masterdata(id, type, created_on, last_update) VALUES(@Id, @Type, NOW(), NOW()) ON CONFLICT ON CONSTRAINT pk_cbv_masterdata DO UPDATE SET last_update = NOW();.
        /// </summary>
        internal static string MasterDataInsert {
            get {
                return ResourceManager.GetString("MasterDataInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT md.type, md.id FROM cbv.masterdata md /**where**/ ORDER BY md.last_update DESC LIMIT @limit.
        /// </summary>
        internal static string MasterDataQuery {
            get {
                return ResourceManager.GetString("MasterDataQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT event_id, epc as id, type, is_quantity, quantity, unit_of_measure FROM epcis.epc WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, field_id as id, parent_id, namespace, name, type, text_value, numeric_value, date_value FROM epcis.custom_field WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, transaction_type as type, transaction_id as id FROM epcis.business_transaction WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, type, source_dest_id as id, direction FROM epcis.source_destination WHERE event_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RelatedQuery {
            get {
                return ResourceManager.GetString("RelatedQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.business_transaction(event_id, transaction_type, transaction_id) VALUES (@EventId, @Type, @Id);.
        /// </summary>
        internal static string StoreBusinessTransaction {
            get {
                return ResourceManager.GetString("StoreBusinessTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.custom_field(event_id, field_id, parent_id, namespace, name, type, text_value, numeric_value, date_value) VALUES (@EventId, @Id, @ParentId, @Namespace, @Name, @Type, @TextValue, @NumericValue, @DateValue);.
        /// </summary>
        internal static string StoreCustomField {
            get {
                return ResourceManager.GetString("StoreCustomField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.epc(event_id, epc, type, is_quantity, quantity, unit_of_measure) VALUES (@EventId, @Id, @Type, @IsQuantity, @Quantity, @UnitOfMeasure);.
        /// </summary>
        internal static string StoreEpcs {
            get {
                return ResourceManager.GetString("StoreEpcs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.error_declaration(event_id, declaration_time, reason) VALUES(@EventId, @DeclarationTime, @Reason);.
        /// </summary>
        internal static string StoreErrorDeclaration {
            get {
                return ResourceManager.GetString("StoreErrorDeclaration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.error_declaration_eventid(event_id, corrective_eventid) VALUES(@EventId, @CorrectiveId);.
        /// </summary>
        internal static string StoreErrorDeclarationIds {
            get {
                return ResourceManager.GetString("StoreErrorDeclarationIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.event(id, request_id, record_time, action, event_type, event_timezone_offset, business_location, business_step, disposition, read_point, transformation_id, event_id) VALUES(@Id, @RequestId, @EventTime, @Action, @Type, @EventTimeZoneOffset, @BusinessLocation, @BusinessStep, @Disposition, @ReadPoint, @TransformationId, @EventId);.
        /// </summary>
        internal static string StoreEvent {
            get {
                return ResourceManager.GetString("StoreEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.request(id, document_time, record_time) VALUES(@Id, @DocumentTime, @RecordTime);.
        /// </summary>
        internal static string StoreRequest {
            get {
                return ResourceManager.GetString("StoreRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.source_destination(event_id, type, source_dest_id, direction) VALUES (@EventId, @Type, @Id, @Direction);.
        /// </summary>
        internal static string StoreSourceDestination {
            get {
                return ResourceManager.GetString("StoreSourceDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM subscriptions.pendingrequest WHERE subscription_id = @SubscriptionId AND request_id = ANY(@RequestId);.
        /// </summary>
        internal static string SubscriptionAcknowledgePendingRequests {
            get {
                return ResourceManager.GetString("SubscriptionAcknowledgePendingRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE from subscriptions.subscription WHERE id = @Id;.
        /// </summary>
        internal static string SubscriptionDelete {
            get {
                return ResourceManager.GetString("SubscriptionDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.subscription_id, s.query_name, s.active FROM subscriptions.subscription s.
        /// </summary>
        internal static string SubscriptionListIds {
            get {
                return ResourceManager.GetString("SubscriptionListIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT p.subscription_id, p.name, pv.value FROM subscriptions.parameter p INNER JOIN subscriptions.parameter_value pv ON pv.parameter_id = p.id;.
        /// </summary>
        internal static string SubscriptionListParameters {
            get {
                return ResourceManager.GetString("SubscriptionListParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT request_id FROM subscriptions.pendingrequest WHERE subscription_id = @SubscriptionId;.
        /// </summary>
        internal static string SubscriptionListPendingRequestIds {
            get {
                return ResourceManager.GetString("SubscriptionListPendingRequestIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.destination, s.subscription_id, s.query_name, s.active, s.trigger, s.report_if_empty, s.schedule_minutes, s.schedule_seconds, s.schedule_hours, s.schedule_month, s.schedule_day_of_month, s.schedule_day_of_week FROM subscriptions.subscription s;.
        /// </summary>
        internal static string SubscriptionsList {
            get {
                return ResourceManager.GetString("SubscriptionsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.subscription(id, subscription_id, trigger, initial_record_time, report_if_empty, destination, query_name,  active, schedule_seconds, schedule_minutes, schedule_hours, schedule_month, schedule_day_of_month, schedule_day_of_week) VALUES(@Id, @SubscriptionId, @Trigger, @InitialRecordTime, @ReportIfEmpty, @Destination, @QueryName, @Active, @Second, @Minute, @Hour, @Month, @DayOfMonth, @DayOfWeek);.
        /// </summary>
        internal static string SubscriptionStore {
            get {
                return ResourceManager.GetString("SubscriptionStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter(id, subscription_id, name) VALUES(@Id, @SubscriptionId, @Name);.
        /// </summary>
        internal static string SubscriptionStoreParameter {
            get {
                return ResourceManager.GetString("SubscriptionStoreParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter_value(id, parameter_id, value) VALUES(@Id, @ParameterId, @Value);.
        /// </summary>
        internal static string SubscriptionStoreParameterValue {
            get {
                return ResourceManager.GetString("SubscriptionStoreParameterValue", resourceCulture);
            }
        }
    }
}
