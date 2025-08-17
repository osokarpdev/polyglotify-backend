using Microsoft.AspNetCore.Mvc;
using PolyglotifyBackend.Models;
using PolyglotifyBackend.Services;

namespace PolyglotifyBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExampleController : ControllerBase
{
    // =============================================================================================
    // 1. CONSTANTS (public, protected internal, internal, protected, private)
    //    These are compile-time constants. They should be placed at the top of the class
    //    as they define the core immutable values used throughout the service.
    // =============================================================================================



    // =============================================================================================
    // 2. FIELDS (public, protected internal, internal, protected, private) (static, readonly, then instance)
    //    This section is for private backing fields. Use an underscore prefix (_)
    //    for instance fields to clearly differentiate them from local variables and parameters.
    // =============================================================================================



    // =============================================================================================
    // 3. PROPERTIES (public, protected internal, internal, protected, private) (static, readonly, then instance)
    //    Properties should come after the constructor. They provide a controlled way
    //    to access and modify the state of the object.
    // =============================================================================================



    // =============================================================================================
    // 4. CONSTRUCTORS
    //    Constructors should follow the fields. They are responsible for initializing the
    //    state of the object. Order from least complex to most complex.
    //    The constructor is used for dependency injection. Place it after the fields.
    // =============================================================================================



    // =============================================================================================
    // 5. ACTIONS (public methods) (GET, POST, PUT, PATCH, DELETE)
    //    These are the public methods decorated with HTTP attributes that the framework
    //    will map to API endpoints. Order them logically (e.g., by HTTP verb).
    // =============================================================================================
}
