﻿using RoguePanda.manager;
using SFML.Graphics;
using System;
using System.IO;

namespace RoguePanda.asset {
    internal class Sprite : AssetBase, IDisposable {
        Texture _texture;

        public Texture texture {
            get {
                if (_texture == null) {
                    using (MemoryStream ms = fileStream) {
                        _texture = new Texture(ms);
                        _texture.Smooth = ConfigManager.Config.SmoothSprites;
                    }
                }
                return _texture;
            }
        }

        public Sprite(string filePath) : base(filePath) {

        }

        protected override AssetType getAssetType() {
            return AssetType.Sprite;
        }

        public void Dispose() {
            ((IDisposable)_texture).Dispose();
        }
    }
}