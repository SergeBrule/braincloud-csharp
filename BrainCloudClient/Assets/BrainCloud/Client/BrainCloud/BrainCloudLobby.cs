﻿//----------------------------------------------------
// brainCloud client source code
// Copyright 2016 bitHeads, inc.
//----------------------------------------------------

namespace BrainCloud
{
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using BrainCloud.Internal;
    using BrainCloud.JsonFx.Json;

    public class BrainCloudLobby
    {
        public Dictionary<string, long> PingData { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public BrainCloudLobby(BrainCloudClient in_client)
        {
            m_clientRef = in_client;
        }

        /// <summary>
        /// Finds a lobby matching the specified parameters
        /// </summary>
        /// 
        public void FindLobby(string in_roomType, int in_rating, int in_maxSteps,
            Dictionary<string, object> in_algo, Dictionary<string, object> in_filterJson, int in_timeoutSecs,
            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbyMaxSteps.Value] = in_maxSteps;
            data[OperationParam.LobbyAlgorithm.Value] = in_algo;
            data[OperationParam.LobbyFilterJson.Value] = in_filterJson;
            data[OperationParam.LobbyTimeoutSeconds.Value] = in_timeoutSecs;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.FindLobby, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Finds a lobby matching the specified parameters WITH PING DATA.  GetRegionsForLobbies and PingRegions must be successfully responded to
        /// prior to calling.
        /// </summary>
        /// 
        public void FindLobbyWithPingData(string in_roomType, int in_rating, int in_maxSteps,
            Dictionary<string, object> in_algo, Dictionary<string, object> in_filterJson, int in_timeoutSecs,
            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbyMaxSteps.Value] = in_maxSteps;
            data[OperationParam.LobbyAlgorithm.Value] = in_algo;
            data[OperationParam.LobbyFilterJson.Value] = in_filterJson;
            data[OperationParam.LobbyTimeoutSeconds.Value] = in_timeoutSecs;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;
            data[OperationParam.PingData.Value] = PingData;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.FindLobbyWithPingData, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Like findLobby, but explicitely geared toward creating new lobbies
        /// </summary>
        /// 
        public void CreateLobby(string in_roomType, int in_rating,
            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode,
            Dictionary<string, object> in_settings, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbySettings.Value] = in_settings;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.CreateLobby, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Like findLobby, but explicitely geared toward creating new lobbies WITH PING DATA.  GetRegionsForLobbies and PingRegions must be successfully responded to
        /// prior to calling.
        /// </summary>
        /// 
        public void CreateLobbyWithPingData(string in_roomType, int in_rating,
            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode,
            Dictionary<string, object> in_settings, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbySettings.Value] = in_settings;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;
            data[OperationParam.PingData.Value] = PingData;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.CreateLobbyWithPingData, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Finds a lobby matching the specified parameters, or creates one
        /// </summary>
        /// 
        public void FindOrCreateLobby(string in_roomType, int in_rating, int in_maxSteps,
            Dictionary<string, object> in_algo,
            Dictionary<string, object> in_filterJson, int in_timeoutSecs,
            bool in_isReady,
            Dictionary<string, object> in_extraJson, string in_teamCode,
            Dictionary<string, object> in_settings, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbyMaxSteps.Value] = in_maxSteps;
            data[OperationParam.LobbyAlgorithm.Value] = in_algo;
            data[OperationParam.LobbyFilterJson.Value] = in_filterJson;
            data[OperationParam.LobbyTimeoutSeconds.Value] = in_timeoutSecs;
            data[OperationParam.LobbySettings.Value] = in_settings;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.FindOrCreateLobby, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Finds a lobby matching the specified parameters, or creates one WITH PING DATA.  GetRegionsForLobbies and PingRegions must be successfully responded to
        /// prior to calling.
        /// </summary>
        /// 
        public void FindOrCreateLobbyWithPingData(string in_roomType, int in_rating, int in_maxSteps,
            Dictionary<string, object> in_algo,
            Dictionary<string, object> in_filterJson, int in_timeoutSecs,
            bool in_isReady,
            Dictionary<string, object> in_extraJson, string in_teamCode,
            Dictionary<string, object> in_settings, string[] in_otherUserCxIds = null,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyRating.Value] = in_rating;
            data[OperationParam.LobbyMaxSteps.Value] = in_maxSteps;
            data[OperationParam.LobbyAlgorithm.Value] = in_algo;
            data[OperationParam.LobbyFilterJson.Value] = in_filterJson;
            data[OperationParam.LobbyTimeoutSeconds.Value] = in_timeoutSecs;
            data[OperationParam.LobbySettings.Value] = in_settings;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;
            data[OperationParam.PingData.Value] = PingData;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.FindOrCreateLobbyWithPingData, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Gets data for the given lobby instance <lobbyId>.
        /// </summary>
        public void GetLobbyData(string in_lobbyID,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.GetLobbyData, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// updates the ready state of the player
        /// </summary>
        public void UpdateReady(string in_lobbyID, bool in_isReady, Dictionary<string, object> in_extraJson,
                                SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.UpdateReady, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// valid only for the owner of the group -- edits the overally lobby config data
        /// </summary>
        public void UpdateSettings(string in_lobbyID, Dictionary<string, object> in_settings,
                                SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbySettings.Value] = in_settings;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.UpdateSettings, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// switches to the specified team (if allowed). Note - may be blocked by cloud code script
        /// </summary>
        public void SwitchTeam(string in_lobbyID, string in_toTeamName,
            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbyToTeamName.Value] = in_toTeamName;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.SwitchTeam, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// sends LOBBY_SIGNAL_DATA message to all lobby members
        /// </summary>
        public void SendSignal(string in_lobbyID, Dictionary<string, object> in_signalData, SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbySignalData.Value] = in_signalData;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.SendSignal, data, callback);
            m_clientRef.SendRequest(sc);
        }


        /// <summary>
        /// User joins the specified lobby. 
        /// </summary>
        public void JoinLobby(string in_lobbyID,
                            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode, string[] in_otherUserCxIds = null,
                            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.JoinLobby, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// User joins the specified lobby WITH PING DATA.  GetRegionsForLobbies and PingRegions must be successfully responded to
        /// prior to calling.
        /// </summary>
        public void JoinLobbyWithPingData(string in_lobbyID,
                            bool in_isReady, Dictionary<string, object> in_extraJson, string in_teamCode, string[] in_otherUserCxIds = null,
                            SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            if (in_otherUserCxIds != null)
            {
                data[OperationParam.LobbyOtherUserCxIds.Value] = in_otherUserCxIds;
            }
            data[OperationParam.LobbyExtraJson.Value] = in_extraJson;
            data[OperationParam.LobbyTeamCode.Value] = in_teamCode;
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbyIsReady.Value] = in_isReady;
            data[OperationParam.PingData.Value] = PingData;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.JoinLobbyWithPingData, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// User leaves the specified lobby. if the user was the owner, a new owner will be chosen
        /// </summary>
        /// 
        public void LeaveLobby(string in_lobbyID, SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.LeaveLobby, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Only valid from the owner of the lobby -- removes the specified member from the lobby
        /// </summary>
        /// 
        public void RemoveMember(string in_lobbyID, string in_connectionId, SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyIdentifier.Value] = in_lobbyID;
            data[OperationParam.LobbyConnectionId.Value] = in_connectionId;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.RemoveMember, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Cancel this members Find, Join and Searching of Lobbies
        /// </summary>
        /// 
        public void CancelFindRequest(string in_roomType, SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyRoomType.Value] = in_roomType;
            data[OperationParam.LobbyConnectionId.Value] = m_clientRef.RTTConnectionID;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.CancelFindRequest, data, callback);
            m_clientRef.SendRequest(sc);
        }

        /// <summary>
        /// Retrieves the region settings for each of the given lobby types. Upon SuccessCallback, will start to PING all 
        /// regions within response.  Once that completes, the associated region Ping Data is retrievable via PingData
        /// </summary>
        /// 
        public void GetRegionsForLobbies(string[] in_roomTypes, SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[OperationParam.LobbyTypes.Value] = in_roomTypes;

            ServerCallback callback = BrainCloudClient.CreateServerCallback(onRegionForLobbiesSuccess + success, failure, cbObject);
            ServerCall sc = new ServerCall(ServiceName.Lobby, ServiceOperation.GetRegionsForLobbies, data, callback);
            m_clientRef.SendRequest(sc);
        }

        public void PingRegions(SuccessCallback success = null, FailureCallback failure = null, object cbObject = null)
        {
            m_pingRegionSuccessCallback = success;
            m_pingRegionObject = cbObject;

            // now we have the region ping data, we can start pinging each region and its defined target, if its a PING type.
            Dictionary<string, object> regionInner = null;
            string targetStr = "";
            int numRegionProcessed = 0;
            foreach (var regionMap in m_regionPingData)
            {
                regionInner = (Dictionary<string, object>)regionMap.Value;
                ++numRegionProcessed;
                if ((string)regionInner["type"] == "PING")
                {
                    m_cachedPingResponses[regionMap.Key] = new List<long>();
                    targetStr = (string)regionInner["target"];

                    pingHost(regionMap.Key, targetStr);
                    pingHost(regionMap.Key, targetStr);
                    pingHost(regionMap.Key, targetStr);
                    pingHost(regionMap.Key, targetStr, numRegionProcessed == m_regionPingData.Count);
                }
            }
        }

        #region private
        private void onRegionForLobbiesSuccess(string in_json, object in_obj)
        {
            PingData = new Dictionary<string, long>();

            Dictionary<string, object> jsonMessage = (Dictionary<string, object>)JsonReader.Deserialize(in_json);
            Dictionary<string, object> data = (Dictionary<string, object>)jsonMessage["data"];
            m_regionPingData = (Dictionary<string, object>)data["regionPingData"];
            m_lobbyTypeRegions = (Dictionary<string, object>)data["lobbyTypeRegions"];
        }

        private void pingHost(string in_region, string in_target, bool in_bLastItem = false)
        {
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                pinger.PingCompleted += (o, e) =>
                {
                    if (e.Error == null && e.Reply.Status == IPStatus.Success)
                    {
                        m_cachedPingResponses[in_region].Add(e.Reply.RoundtripTime);
                        if (m_cachedPingResponses[in_region].Count == 4)
                        {
                            // we have all four, accumulate the top 3, and average them
                            long totalAccumulated = 0;
                            long highestValue = 0;
                            foreach (var pingResponse in m_cachedPingResponses[in_region])
                            {
                                totalAccumulated += pingResponse;
                                if (pingResponse > highestValue)
                                {
                                    highestValue = pingResponse;
                                }
                            }

                            // accumulated ALL, now subtract the highest value
                            totalAccumulated -= highestValue;
                            PingData[in_region] = totalAccumulated / (m_cachedPingResponses[in_region].Count - 1);

                            if (in_bLastItem && m_pingRegionSuccessCallback != null)
                            {
                                m_pingRegionSuccessCallback("", m_pingRegionObject);
                            }
                        }
                    }
                };

                pinger.SendAsync(in_target, null);
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
        }

        private Dictionary<string, object> m_regionPingData;
        private Dictionary<string, object> m_lobbyTypeRegions;
        private Dictionary<string, List<long>> m_cachedPingResponses = new Dictionary<string, List<long>>();
        private SuccessCallback m_pingRegionSuccessCallback = null;
        private object m_pingRegionObject = null;

        /// <summary>
        /// Reference to the brainCloud client object
        /// </summary>
        private BrainCloudClient m_clientRef;
        #endregion
    }
}
