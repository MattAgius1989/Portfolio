using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Maps;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace _30015379_DWA_Project
{
    public sealed partial class DraggablePin : UserControl
    {
        private Map _map;
        private bool isDragging = false;
        Location _center;

        public DraggablePin(Map map)
        {
            _map = map;
        }

        public bool Draggable { get; set; }

        public Action<Location> Drag;

        public Action<Location> DragStart;

        public Action<Location> DragEnd;

        protected override void OnPointerPressed(PointerRoutedEventArgs e)
        {
            base.OnPointerPressed(e);

            if (Draggable)
            {
                if (_map != null)
                {
                    _center = _map.Center;

                    _map.ViewChanged += Map_ViewChanged;
                    _map.PointerReleasedOverride += Map_PointerReleased;
                    _map.PointerMovedOverride += Map_PointerMoved;
                }

                var pointerPosition = e.GetCurrentPoint(_map);

                Location location = null;

                if (_map.TryPixelToLocation(pointerPosition.Position, out location))
                {
                    MapLayer.SetPosition(this, location);
                }

                if (DragStart != null)
                {
                    DragStart(location);
                }

                this.isDragging = true;
            }
        }

        private void Map_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (this.isDragging)
            {
                var pointerPosition = e.GetCurrentPoint(_map);

                Location location = null;

                if (_map.TryPixelToLocation(pointerPosition.Position, out location))
                {
                    MapLayer.SetPosition(this, location);
                }

                if (Drag != null)
                {
                    Drag(location);
                }
            }
        }

        private void Map_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (_map != null)
            {
                _map.ViewChanged -= Map_ViewChanged;
                _map.PointerReleased -= Map_PointerReleased;
                _map.PointerMovedOverride -= Map_PointerMoved;
            }

            var pointerPosition = e.GetCurrentPoint(_map);

            Location location = null;

            if (_map.TryPixelToLocation(pointerPosition.Position, out location))
            {
                MapLayer.SetPosition(this, location);
            }

            if (DragEnd != null)
            {
                DragEnd(location);
            }

            this.isDragging = false;
        }

        private void Map_ViewChanged(object sender, ViewChangedEventArgs e)
        {
            if (isDragging)
            {
                _map.Center = _center;
            }
        }
    }
}
