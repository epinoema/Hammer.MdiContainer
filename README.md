# Hammer.MdiContainer
This is a fork from the excelent MDIContainer for WPF. You can find the original codeplex project here:

https://mdicontainer.codeplex.com/

I have made a few fixes/enhancements:
* Windows cannot be mistakenly hidden outside of the visible area of the container
* Keyboard focus outside of the container does not modify selected window in the container 
* Date picker popup causes the window to be active
* There is a new DependencyProperty: IsModal, which draws an adorner around the window so that other windows cannot take focus, making this window modal. Use only on the active window, otherwise you will experience something like a Venn's diagram effect :)
* Refactored a few names - simplified code here and there.


The source code is licensed under the GNU General Public License version 3 (GPLv3)
