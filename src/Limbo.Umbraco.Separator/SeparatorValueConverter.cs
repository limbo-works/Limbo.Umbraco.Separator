﻿using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator;

public class SeparatorValueConverter : PropertyValueConverterBase {

    public override bool IsConverter(IPublishedPropertyType propertyType) {
        return propertyType.EditorAlias == SeparatorDataEditor.EditorAlias;
    }

    public override object? ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object? source, bool preview) {
        return source;
    }

    public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object? inter, bool preview) {
        return new SeparatorModel();
    }

    public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
        return typeof(SeparatorModel);
    }

    public override PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) {
        return PropertyCacheLevel.Element;
    }

}