﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pustota.Maven.Models;
using Pustota.Maven.Serialization;
using Pustota.Maven.System;

namespace Pustota.Maven
{
	// TODO: support multiple repositories within solution
	internal class Solution : ISolution
	{
		private readonly IFileSystemAccess _fileIo;
		private readonly IProjectTreeLoader _loader;

		private IList<Tuple<string,IProject>> _projects;

		public string BaseDir { get; private set; }

		public IEnumerable<IProject> AllProjects { get { return _projects.Select(item => item.Item2); } }

		//public ProjectsValidations Validations { get; private set; }
		//public ExternalModulesRepository ExternalModules { get; private set; }

		internal Solution(IFileSystemAccess fileIo, IProjectTreeLoader loader)
		{
			_fileIo = fileIo;
			_loader = loader;
		}

		internal void Open(string fileOrFolderName)
		{
			if (fileOrFolderName == null) throw new ArgumentNullException("fileOrFolderName");

			var fullPath = _fileIo.GetFullPath(fileOrFolderName);
			if (_fileIo.IsFileExist(fullPath))
			{
				BaseDir = _fileIo.GetDirectoryName(fullPath);
			}
			else if (_fileIo.IsDirectoryExist(fullPath))
			{
				BaseDir = fullPath;
			}
			else
			{
				throw new FileNotFoundException(fullPath);
			}

			_projects = _loader.LoadProjectTree(fileOrFolderName).ToList();
		}

//		public void Reload()
//		{
//			Load();
//		}

//		public IEnumerable<ValidationError> Validate()
//		{
//			Validations.Validate();
//			return Validations.ValidationErrors;
//		}

//		private void Load()
//		{
////			ExternalModules = new ExternalModulesRepository(BaseDir); // REVIEW: BaseDir should be solution 
////			Validations = new ProjectsValidations(ProjectsRepository, ExternalModules);
//		}

//		public bool Changed
//		{
//			// _ignoredValidations.Changed
//			// _externalModules.Changed
//			get { return ProjectsRepository.Changed; }
//		}

//		public IEnumerable<IProject> Projects
//		{
//			get { return _projects.Select(pc => pc.Project); }
//		}

		public void ForceSaveAll()
		{
			foreach (var tuple in _projects)
			{
				//				var content = _projectSerializer.Serialize((Project) container.Project);
				//				_fileIo.WriteAllText(container.Path, content);
			}
		}

	}
}
