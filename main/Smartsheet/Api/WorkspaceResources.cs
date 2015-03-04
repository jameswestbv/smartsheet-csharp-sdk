﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed To in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System.Collections.Generic;

namespace Smartsheet.Api
{


	using Workspace = Api.Models.Workspace;

	/// <summary>
	/// <para>This interface provides methods To access Workspace resources.</para>
	/// 
	/// <para>Thread Safety: Implementation of this interface must be thread safe.</para>
	/// </summary>
	public interface WorkspaceResources
	{

		/// <summary>
		/// <para>List all Workspaces.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: GET /Workspaces</para>
		/// </summary>
		/// <returns> the list of Workspaces (note that an empty list will be returned if there are none) </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		IList<Workspace> ListWorkspaces();

        IList<Workspace> ListWorkspaces(bool loadAll);

		/// <summary>
		/// <para>Get a workspace.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: GET /workspace/{Id}</para>
		/// </summary>
		/// <param name="id"> the Id </param>
		/// <returns> the workspace (note that if there is no such resource, this method will throw ResourceNotFoundException
		/// rather than returning null) </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Workspace GetWorkspace(long id);

        Workspace GetWorkspace(long id, bool loadAll);

		/// <summary>
		/// <para>Create a workspace.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: POST /Workspaces</para>
		/// 
		/// </summary>
		/// <param name="workspace"> the workspace To create </param>
		/// <returns> the created workspace </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Workspace CreateWorkspace(Workspace workspace);

		/// <summary>
		/// <para>Update a workspace.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: PUT /workspace/{Id}</para>
		/// </summary>
		/// <param name="workspace"> the workspace To update </param>
		/// <returns> the updated workspace (note that if there is no such resource, this method will throw
		/// ResourceNotFoundException rather than returning null) </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Workspace UpdateWorkspace(Workspace workspace);

		/// <summary>
		/// <para>Delete a workspace.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: DELETE /workspace{Id}</para>
		/// </summary>
		/// <param name="id"> the Id of the workspace </param>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void DeleteWorkspace(long id);

		/// <summary>
		/// <para>Return the WorkspaceFolderResources object that provides access To Folder resources associated with Workspace
		/// resources.</para>
		/// </summary>
		/// <returns> the workspace folder resources </returns>
		WorkspaceFolderResources Folders();

		/// <summary>
		/// <para>Return the ShareResources object that provides access To Share resources associated with Workspace 
		/// resources.</para>
		/// </summary>
		/// <returns> the share resources object </returns>
		ShareResources Shares();
	}

}