
using System;
using System.Windows;
using System.Diagnostics;
using Smrf.NodeXL.Core;

namespace Smrf.NodeXL.Visualization.Wpf
{
    //*****************************************************************************
    //  Class: EdgeToolTipShownEventArgs
    //
    /// <summary>
    /// Provides information for events fired when a tooltip is shown for an edge.
    /// </summary>
    //*****************************************************************************

    public class EdgeToolTipShownEventArgs : EdgeEventArgs
    {
        //*************************************************************************
        //  Constructor: EdgeToolTipShownEventArgs()
        //
        /// <summary>
        /// Initializes a new instance of the EdgeToolTipShownEventArgs class.
        /// </summary>
        ///
        /// <param name="edge">
        /// Edge for which a tooltip is shown.
        /// </param>
        //*************************************************************************

        public EdgeToolTipShownEventArgs
        (
            IEdge edge

        )
            : base(edge)
        {
            m_oEdgeToolTip = null;

            AssertValid();
        }

        //*************************************************************************
        //  Property: EdgeToolTip
        //
        /// <summary>
        /// Gets or sets the UIElement to use for the edge tooltip.
        /// </summary>
        ///
        /// <value>
        /// The UIElement to use.  The default value is null.
        /// </value>
        ///
        /// <remarks>
        /// See <see cref="NodeXLControl.ShowEdgeToolTips" /> for information on
        /// how to display a custom tooltip when the mouse is hovered over an
        /// edge.
        ///
        /// <para>
        /// If this property is left at its default value of null, the text stored
        /// on the edge's ReservedMetadataKeys.<see
        /// cref="ReservedMetadataKeys.PerEdgeToolTip" /> key is used for the
        /// tooltip.  If there is no such key, a tooltip isn't displayed.
        /// </para>
        ///
        /// </remarks>
        //*************************************************************************

        public UIElement
        EdgeToolTip
        {
            get
            {
                AssertValid();

                return (m_oEdgeToolTip);
            }

            set
            {
                m_oEdgeToolTip = value;

                AssertValid();
            }
        }


        //*************************************************************************
        //  Method: AssertValid()
        //
        /// <summary>
        /// Asserts if the object is in an invalid state.  Debug-only.
        /// </summary>
        //*************************************************************************

        // [Conditional("DEBUG")] 

        public override void
        AssertValid()
        {
            base.AssertValid();

            // m_oEdgeToolTip
        }


        //*************************************************************************
        //  Protected member data
        //*************************************************************************

        /// The UIElement to use for the edge tooltip, or null to use the tooltip
        /// string stored in the edge's metadata.

        protected UIElement m_oEdgeToolTip;
    }


    //*****************************************************************************
    //  Delegate: EdgeToolTipShownEventHandler
    //
    /// <summary>
    /// Represents a method that will handle an event fired when a tooltip is shown
    /// for an edge.
    /// </summary>
    ///
    /// <param name="sender">
    /// The object that fired the event.
    /// </param>
    ///
    /// <param name="e">
    /// Provides information about the edge and its tooltip.
    /// </param>
    //*****************************************************************************

    public delegate void
    EdgeToolTipShownEventHandler
    (
        Object sender,
        EdgeToolTipShownEventArgs e
    );

}
