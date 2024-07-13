// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: SuppressMessage("Performance",
    "CA1812:Avoid uninstantiated internal classes",
    Justification = "Unneeded spam",
    Scope = "namespaceanddescendants",
    Target = "~N:RuleTests")]

[assembly: SuppressMessage("Performance",
    "CA1852:Seal internal types",
    Justification = "Unneeded spam",
    Scope = "namespaceanddescendants",
    Target = "~N:RuleTests")]

[assembly: SuppressMessage("Globalization",
    "CA1303:Do not pass literals as localized parameters",
    Justification = "Unneeded spam",
    Scope = "namespaceanddescendants",
    Target = "~N:RuleTests")]
