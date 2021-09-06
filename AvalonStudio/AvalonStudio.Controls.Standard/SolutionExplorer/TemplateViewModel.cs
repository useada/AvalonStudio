﻿using AvalonStudio.Extensibility.Templating;
using AvalonStudio.MVVM;
using System.Collections.Generic;
using System.Linq;

namespace AvalonStudio.Controls.Standard.SolutionExplorer
{
    class TemplateViewModel : ViewModel
    {
        private ITemplate _inner;

        public TemplateViewModel(ITemplate template)
        {
            _inner = template;

            Parameters = _inner.Parameters.Select(p => new TemplateParameterViewModel(_inner, p)).ToList();
        }

        public IEnumerable<TemplateParameterViewModel> Parameters { get; }

        public string Name => _inner.Name;

        public ITemplate Template => _inner;
    }
}
