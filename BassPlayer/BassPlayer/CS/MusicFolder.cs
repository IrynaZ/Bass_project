using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibrary;

namespace BassPlayer.CS
{
    class MusicFolder
    {
        public string folderName { get; protected set; }
        public string folderType { get; protected set; }
        public List<MusicFile> folderItems { get; protected set; }
        public List<MusicFolder> subFolders { get; protected set; }

        public MusicFolder(string name, string type)
        {
            this.folderType = name;
            this.folderType = type;
            this.folderItems = new List<MusicFile>();
            this.subFolders = new List<MusicFolder>();
        }

        public MusicFolder(string name, string type, List<MusicFile> ititialItemsList)
        {
            this.folderName = name;
            this.folderType = type;
            this.folderItems = new List<MusicFile>();
            this.folderItems = ititialItemsList;
            this.subFolders = new List<MusicFolder>();
        }

        public void AddItem(MusicFile item)
        {
            folderItems.Add(item);
        }

        public void AddItemFromFile(string file)
        {
            if (!Vars.FileAlreadyExistsInFiles(file) && (Vars.FileIsMP3(file)))
            {
                Vars.Files.Add(file);
                MusicFile musicItem = new MusicFile(file);
                this.AddItem(musicItem);
            }
        }

        public void RemoveItem(MusicFile item)
        {
            folderItems.Remove(item);
            Vars.Files.Remove(item.filePath);
        }

        public MusicFile GetItem(string identificator)
        {
            return folderItems.Find((x => (x.fileName == identificator) || (x.song == identificator)));
        }

        public void AddSubfolder(string name, string type, List<MusicFile> itemsList)
        {
            this.subFolders.Add(new MusicFolder(name, type, itemsList));            
        }

        public MusicFolder GetSubFolder(string name)
        {
            return this.subFolders.Find(x => x.folderName == name);
        }

        public void RemoveSubFolder(string name)
        {
            List<MusicFile> tempList = this.GetSubFolder(name).folderItems;            
            foreach (MusicFile item in tempList)
            {
                this.RemoveItem(item);
                Vars.Files.Remove(item.filePath);
            }
            this.subFolders.Remove(this.GetSubFolder(name));           
        }

        public void SyncFolderItems(List<MusicFile> otherFolderItems)
        {
            if (this.folderItems != otherFolderItems)
            {
                this.folderItems.Clear();
                this.folderItems = otherFolderItems;
            }
        }

        public void ReadFolderFromFile(string filePath)
        {
            List<string> files = new List<string>();
            FileHandling.ReadFromFile(filePath, out files);
            foreach (string file in files)
            {
                this.AddItemFromFile(file);
            }
        }

        public void AddFolderToListView(ListView targetListView)
        {
            targetListView.Clear();
            switch (folderType)
            {
                case "Music":
                    foreach (MusicFile item in folderItems)
                    {
                        targetListView.Items.Add(new ListViewItem(new[] { item.fileName, item.song, item.artist, item.album, item.genre }));
                    }
                    break;
                case "Songs":
                    foreach (MusicFile item in folderItems)
                    {
                        if (item.song != null)
                            targetListView.Items.Add(new ListViewItem(new[] { item.song, item.fileName, item.artist, item.album, item.genre }));
                    }
                    break;
                case "Artists":
                case "Albums":
                case "Genres":
                    foreach (MusicFolder item in subFolders)
                    {
                        if (item != null)
                            targetListView.Items.Add(new ListViewItem(new[] { item.folderName }));
                    }
                    break;
            }

        }

        public void FillSubFolders()
        {
            if (this.subFolders.Count != 0)
                this.subFolders.Clear();
            List<string> items = new List<string>();
            List<string> itemsNoDuplicates = new List<string>();
            foreach (MusicFile musicItem in this.folderItems)
            {
                switch (this.folderType)
                {
                    case "Artists":
                        items.Add(musicItem.artist);
                        break;
                    case "Albums":
                        items.Add(musicItem.album);
                        break;
                    case "Genres":
                        items.Add(musicItem.genre);
                        break;
                }
            }
            itemsNoDuplicates = items.Distinct().ToList<string>();
            foreach (string item in itemsNoDuplicates)
            {
                switch (this.folderType)
                {
                    case "Artists":
                        if (item != null)
                            this.AddSubfolder(item, "Music", folderItems.FindAll(x => x.artist == item));
                        break;
                    case "Albums":
                        if (item != null)
                            this.AddSubfolder(item, "Music", folderItems.FindAll(x => x.album == item));
                        break;
                    case "Genres":
                        if (item != null)
                            this.AddSubfolder(item, "Music", folderItems.FindAll(x => x.genre == item));
                        break;
                }
            }
        }

        public void ExpandSubFolderInListView(string subfolderName, ListView targetListView)
        {
            MusicFolder subFolder = this.GetSubFolder(subfolderName);
            if (subFolder != null)
            {
                subFolder.AddFolderToListView(targetListView);
            }
            else
            {
                this.AddFolderToListView(targetListView);
            }
        }

        public void RemoveItemInSubfolder(string subfolderName, MusicFile selectedItem)
        {
            MusicFolder subFolder = this.GetSubFolder(subfolderName);
            subFolder.RemoveItem(selectedItem);
        }
    }
}
