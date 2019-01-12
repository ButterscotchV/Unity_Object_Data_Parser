using System;
using System.Collections.Generic;

namespace Object_Data_Parser
{
	public enum FileType
	{
		File,
		Directory
	}

	public class FileManager
	{
		public string Path { get; protected set; }
		public string Name { get; protected set; }

		public string ParentDirectoryString { get; protected set; }
		public Directory ParentDirectory
		{
			get
			{
				FileManager input = FromPath(ParentDirectoryString);
				if (input != null && input.FileType == FileType.Directory)
				{
					return (Directory)input;
				}

				return null;
			}
		}
		public bool HasParentDirectory => ParentDirectory != null;

		public FileType FileType { get; protected set; }

		public static FileManager FromPath(string path)
		{
			string[] parts = path.Split(System.IO.Path.DirectorySeparatorChar);
			string name = (string.IsNullOrEmpty(parts[parts.Length - 1]) && parts.Length > 1 ? parts[parts.Length - 2] : parts[parts.Length - 1]);

			if (System.IO.File.Exists(path))
			{
				string[] extParts = name.Split('.');
				string extension = (extParts.Length > 1 && !string.IsNullOrEmpty(extParts[extParts.Length - 1]) ? extParts[extParts.Length - 1] : "");

				return new File(path, name, extension);
			}

			if (System.IO.Directory.Exists(path))
			{
				return new Directory(path, name);
			}

			return null;
		}

		public string GetRelativePathTo(string workingPath)
		{
			return (!string.IsNullOrEmpty(workingPath) && Path.Contains(workingPath) ? Path.Remove(Path.IndexOf(workingPath), workingPath.Length) : Path);
		}

		public string GetSeparatorWithRelativePath(string workingPath)
		{
			string relativePath = GetRelativePathTo(workingPath);
			return (relativePath.StartsWith(System.IO.Path.DirectorySeparatorChar.ToString()) ? relativePath : System.IO.Path.DirectorySeparatorChar + relativePath);
		}
	}

	public class File : FileManager
	{
		public string Extension { get; protected set; }

		public File(string path, string name, string extension)
		{
			Path = path;
			Name = name;
			Extension = extension;

			string dirPath = path.Remove(path.LastIndexOf(name), name.Length);

			ParentDirectoryString = dirPath;

			FileType = FileType.File;
		}

		public void UpdateInfoFrom(FileManager input)
		{
			if (input != null && input.FileType == FileType.File)
			{
				File newFile = (File)input;

				Path = newFile.Path;
				Name = newFile.Name;
				Extension = newFile.Extension;

				ParentDirectoryString = newFile.ParentDirectoryString;
			}
		}

		public void Rename(string newName)
		{
			string newPath = (HasParentDirectory ? ParentDirectory.GetPathWithSeparator() + newName : newName);
			System.IO.File.Move(Path, newPath);

			// Update File info
			UpdateInfoFrom(FromPath(newPath));
		}
	}

	public class Directory : FileManager
	{
		public Directory(string path, string name)
		{
			Path = path;
			Name = name;
			FileType = FileType.Directory;

			Console.WriteLine("name: " + (string.IsNullOrEmpty(name) ? "null" : name));
			Console.WriteLine("path: " + path);

			string dirPath = path.Remove(path.LastIndexOf(name), name.Length);

			ParentDirectoryString = dirPath;
		}

		public void UpdateInfoFrom(FileManager input)
		{
			if (input != null && input.FileType == FileType.Directory)
			{
				Directory newDir = (Directory)input;

				Path = newDir.Path;
				Name = newDir.Name;

				ParentDirectoryString = newDir.ParentDirectoryString;
			}
		}

		public string GetPathWithSeparator()
		{
			return (Path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) ? Path : Path + System.IO.Path.DirectorySeparatorChar);
		}

		public void Rename(string newName)
		{
			string newPath = (HasParentDirectory ? ParentDirectory.GetPathWithSeparator() + newName : newName);
			System.IO.Directory.Move(Path, newPath);

			// Update Directory info
			UpdateInfoFrom(FromPath(newPath));
		}

		public Directory[] GetChildren()
		{
			List<Directory> directories = new List<Directory>();

			string[] subdirectoryEntries = System.IO.Directory.GetDirectories(Path);
			foreach (string subdirectory in subdirectoryEntries)
			{
				FileManager file = FromPath(subdirectory);

				if (file != null && file.FileType == FileType.Directory)
				{
					directories.Add((Directory)file);
				}
			}

			return directories.ToArray();
		}

		public File[] GetFiles()
		{
			List<File> directories = new List<File>();

			string[] subdirectoryEntries = System.IO.Directory.GetFiles(Path);
			foreach (string fileName in subdirectoryEntries)
			{
				FileManager file = FromPath(fileName);

				if (file != null && file.FileType == FileType.File)
				{
					directories.Add((File)file);
				}
			}

			return directories.ToArray();
		}
	}
}
