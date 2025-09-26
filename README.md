# Customize-grid-switch-column-checked-and-unchecked-state-color-xamarin-datagrid

This sample shows how to color the Switch used by GridSwitchColumn in a Syncfusion Xamarin.Forms DataGrid. The goal is to control the on-state track (OnColor) and the thumb color for both on and off states using a custom CellTemplate. This version keeps only the essentials so you can implement quickly.

## What you get
- A boolean column rendered as a Switch
- Custom colors for the on-state track and thumb
- Guidance for Android and iOS differences

## Quick setup
1) Add SfDataGrid to your page and bind ItemsSource.
2) Use GridSwitchColumn with a CellTemplate to host a Switch.
3) Bind Switch.IsToggled to your boolean field (TwoWay).
4) Set Switch.OnColor for the on-state track; set Switch.ThumbColor via triggers for both states.
5) Define colors in App.xaml resources (optionally with OnPlatform for platform-specific hues).

## Core idea
- The default editor is replaced by a DataTemplate to gain color control.
- Use DataTriggers on IsToggled to swap ThumbColor (e.g., White when true, Gray when false).
- Off-track color isn’t directly exposed by Xamarin.Forms; accept platform gray or simulate with a styled container/effect.

## Minimal outline (pseudo-XAML)
- GridSwitchColumn.CellTemplate -> Grid -> Switch
- Bind: IsToggled = {Binding IsActive}
- Set: OnColor = {StaticResource AccentColor}
- Triggers: if IsToggled true => ThumbColor = White; else => ThumbColor = Gray

## Platform notes
- Android: OnColor = track tint when on; ThumbColor supported. Ensure contrast for accessibility.
- iOS: OnColor = UISwitch OnTintColor; ThumbColor = ThumbTintColor. Off track remains system gray unless custom renderer/effect is used.
