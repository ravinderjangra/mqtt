﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Net.Mqtt.Client.Properties {
    using System;
	using System.Reflection;
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Net.Mqtt.Client.Properties.Resources", typeof(Resources).GetTypeInfo ().Assembly);
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
        ///   Looks up a localized string similar to The client {0} has been disconnected while trying to perform the connection.
        /// </summary>
        internal static string Client_ConnectionDisconnected {
            get {
                return ResourceManager.GetString("Client_ConnectionDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to connect the client {0}.
        /// </summary>
        internal static string Client_ConnectionError {
            get {
                return ResourceManager.GetString("Client_ConnectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A timeout occured while waiting for the client {0} connection confirmation.
        /// </summary>
        internal static string Client_ConnectionTimeout {
            get {
                return ResourceManager.GetString("Client_ConnectionTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connect packet of client {0} has not been accepted by the server. Status: {1}. The connection will be closed.
        /// </summary>
        internal static string Client_ConnectNotAccepted {
            get {
                return ResourceManager.GetString("Client_ConnectNotAccepted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while initializing a client.
        /// </summary>
        internal static string Client_InitializeError {
            get {
                return ResourceManager.GetString("Client_InitializeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to subscribe the client {0} to topic {1}.
        /// </summary>
        internal static string Client_SubscribeError {
            get {
                return ResourceManager.GetString("Client_SubscribeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A timeout occured while waiting for the subscribe confirmation of client {0} for topic {1}.
        /// </summary>
        internal static string Client_SubscribeTimeout {
            get {
                return ResourceManager.GetString("Client_SubscribeTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client {0} has been disconnected while trying to perform the subscription to topic {1}.
        /// </summary>
        internal static string Client_SubscriptionDisconnected {
            get {
                return ResourceManager.GetString("Client_SubscriptionDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The underlying connection has been disconnected unexpectedly.
        /// </summary>
        internal static string Client_UnexpectedChannelDisconnection {
            get {
                return ResourceManager.GetString("Client_UnexpectedChannelDisconnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client {0} has been disconnected while trying to perform the unsubscribe to topics: {1}.
        /// </summary>
        internal static string Client_UnsubscribeDisconnected {
            get {
                return ResourceManager.GetString("Client_UnsubscribeDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to unsubscribe the client {0} of topics: {1}.
        /// </summary>
        internal static string Client_UnsubscribeError {
            get {
                return ResourceManager.GetString("Client_UnsubscribeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A timeout occured while waiting for the unsubscribe confirmation of client {0} for topics: {1}.
        /// </summary>
        internal static string Client_UnsubscribeTimeout {
            get {
                return ResourceManager.GetString("Client_UnsubscribeTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first packet received from the Server must be a ConnectAck packet. The connection will be closed..
        /// </summary>
        internal static string ClientPacketListener_FirstReceivedPacketMustBeConnectAck {
            get {
                return ResourceManager.GetString("ClientPacketListener_FirstReceivedPacketMustBeConnectAck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No session has been found for client {0}.
        /// </summary>
        internal static string SessionRepository_ClientSessionNotFound {
            get {
                return ResourceManager.GetString("SessionRepository_ClientSessionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Cleaned old session.
        /// </summary>
        internal static string Tracer_Client_CleanedOldSession {
            get {
                return ResourceManager.GetString("Tracer_Client_CleanedOldSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Created new client session.
        /// </summary>
        internal static string Tracer_Client_CreatedSession {
            get {
                return ResourceManager.GetString("Tracer_Client_CreatedSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Removed client session as part of Disconnect.
        /// </summary>
        internal static string Tracer_Client_DeletedSessionOnDisconnect {
            get {
                return ResourceManager.GetString("Tracer_Client_DeletedSessionOnDisconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Disposing. Reason: {1}.
        /// </summary>
        internal static string Tracer_Client_Disposing {
            get {
                return ResourceManager.GetString("Tracer_Client_Disposing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client - Packet observable sequence has been completed, hence closing the channel.
        /// </summary>
        internal static string Tracer_Client_PacketsObservableCompleted {
            get {
                return ResourceManager.GetString("Tracer_Client_PacketsObservableCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Dispatching {1} message to flow {2}.
        /// </summary>
        internal static string Tracer_ClientPacketListener_DispatchingMessage {
            get {
                return ResourceManager.GetString("Tracer_ClientPacketListener_DispatchingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Dispatching Publish message to flow {1} and topic {2}.
        /// </summary>
        internal static string Tracer_ClientPacketListener_DispatchingPublish {
            get {
                return ResourceManager.GetString("Tracer_ClientPacketListener_DispatchingPublish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client - An error occurred while listening and dispatching packets.
        /// </summary>
        internal static string Tracer_ClientPacketListener_Error {
            get {
                return ResourceManager.GetString("Tracer_ClientPacketListener_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - First packet from Server has been received. Type: {1}.
        /// </summary>
        internal static string Tracer_ClientPacketListener_FirstPacketReceived {
            get {
                return ResourceManager.GetString("Tracer_ClientPacketListener_FirstPacketReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - No packet has been sent in {1} seconds. Sending Ping to Server to maintain Keep Alive.
        /// </summary>
        internal static string Tracer_ClientPacketListener_SendingKeepAlive {
            get {
                return ResourceManager.GetString("Tracer_ClientPacketListener_SendingKeepAlive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disposing {0}.
        /// </summary>
        internal static string Tracer_Disposing {
            get {
                return ResourceManager.GetString("Tracer_Disposing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - An application message for topic {1} was received.
        /// </summary>
        internal static string Tracer_NewApplicationMessageReceived {
            get {
                return ResourceManager.GetString("Tracer_NewApplicationMessageReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client {0} - Packet Channel observable sequence has been completed.
        /// </summary>
        internal static string Tracer_PacketChannelCompleted {
            get {
                return ResourceManager.GetString("Tracer_PacketChannelCompleted", resourceCulture);
            }
        }
    }
}
