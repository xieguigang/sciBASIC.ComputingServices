﻿Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.Net

Namespace FileSystem

    ''' <summary>
    ''' Provides properties and methods for working with drives, files, and directories on remote server.
    ''' (分布式文件系统)
    ''' </summary>
    Public Class FileSystem

        ReadOnly _portal As IPEndPoint

        Sub New(portal As IPEndPoint)
            _portal = portal
        End Sub

        '
        ' Summary:
        '     Gets or sets the current directory.
        '
        ' Returns:
        '     The current directory for file I/O operations.
        '
        ' Exceptions:
        '   T:System.IO.DirectoryNotFoundException:
        '     The path is not valid.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Property CurrentDirectory As String
            Get

            End Get
            Set(value As String)

            End Set
        End Property

        '
        ' Summary:
        '     Returns a read-only collection of all available drive names.
        '
        ' Returns:
        '     A read-only collection of all available drives as System.IO.DriveInfo objects.
        Public ReadOnly Property Drives As ReadOnlyCollection(Of DriveInfo)

        '
        ' Summary:
        '     Copies the contents of a directory to another directory.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     The directory to be copied.
        '
        '   destinationDirectoryName:
        '     The location to which the directory contents should be copied.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The new name specified for the directory contains a colon (:) or slash (\ or
        '     /).
        '
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     destinationDirectoryName or sourceDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The source directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source directory is a root directory
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing file.
        '
        '   T:System.IO.IOException:
        '     The source path and target path are the same.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A folder name in the path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     A destination file exists but cannot be accessed.
        Public Sub CopyDirectory(sourceDirectoryName As String, destinationDirectoryName As String)

        End Sub
        '
        ' Summary:
        '     Copies the contents of a directory to another directory.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     The directory to be copied.
        '
        '   destinationDirectoryName:
        '     The location to which the directory contents should be copied.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The new name specified for the directory contains a colon (:) or slash (\ or
        '     /).
        '
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     destinationDirectoryName or sourceDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The source directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source directory is a root directory
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing file.
        '
        '   T:System.IO.IOException:
        '     The source path and target path are the same.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A folder name in the path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     A destination file exists but cannot be accessed.
        '
        '   T:System.OperationCanceledException:
        '     ShowUI is set to UIOption.AllDialogs and the user cancels the operation, or one
        '     or more files in the directory cannot be copied.
        Public Sub CopyDirectory(sourceDirectoryName As String, destinationDirectoryName As String, showUI As UIOption)

        End Sub
        '
        ' Summary:
        '     Copies the contents of a directory to another directory.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     The directory to be copied.
        '
        '   destinationDirectoryName:
        '     The location to which the directory contents should be copied.
        '
        '   overwrite:
        '     True to overwrite existing files; otherwise False. Default is False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The new name specified for the directory contains a colon (:) or slash (\ or
        '     /).
        '
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     destinationDirectoryName or sourceDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The source directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source directory is a root directory
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing file.
        '
        '   T:System.IO.IOException:
        '     The source path and target path are the same.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A folder name in the path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     A destination file exists but cannot be accessed.
        Public Sub CopyDirectory(sourceDirectoryName As String, destinationDirectoryName As String, overwrite As Boolean)

        End Sub
        '
        ' Summary:
        '     Copies the contents of a directory to another directory.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     The directory to be copied.
        '
        '   destinationDirectoryName:
        '     The location to which the directory contents should be copied.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   onUserCancel:
        '     Specifies what should be done if the user clicks Cancel during the operation.
        '     Default is Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The new name specified for the directory contains a colon (:) or slash (\ or
        '     /).
        '
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     destinationDirectoryName or sourceDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The source directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source directory is a root directory
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing file.
        '
        '   T:System.IO.IOException:
        '     The source path and target path are the same.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A folder name in the path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     A destination file exists but cannot be accessed.
        '
        '   T:System.OperationCanceledException:
        '     ShowUI is set to UIOption.AllDialogs and the user cancels the operation, or one
        '     or more files in the directory cannot be copied.
        Public Sub CopyDirectory(sourceDirectoryName As String, destinationDirectoryName As String, showUI As UIOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Copies a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     The file to be copied.
        '
        '   destinationFileName:
        '     The location to which the file should be copied.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     The system could not retrieve the absolute path.
        '
        '   T:System.ArgumentException:
        '     destinationFileName contains path information.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName or sourceFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing directory.
        '
        '   T:System.IO.IOException:
        '     The user does not have sufficient permissions to access the file.
        '
        '   T:System.IO.IOException:
        '     A file in the target directory with the same name is in use.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub CopyFile(sourceFileName As String, destinationFileName As String)

        End Sub
        '
        ' Summary:
        '     Copies a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     The file to be copied.
        '
        '   destinationFileName:
        '     The location to which the file should be copied.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     The system could not retrieve the absolute path.
        '
        '   T:System.ArgumentException:
        '     destinationFileName contains path information.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName or sourceFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing directory.
        '
        '   T:System.IO.IOException:
        '     The user does not have sufficient permissions to access the file.
        '
        '   T:System.IO.IOException:
        '     A file in the target directory with the same name is in use.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub CopyFile(sourceFileName As String, destinationFileName As String, showUI As UIOption)

        End Sub
        '
        ' Summary:
        '     Copies a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     The file to be copied.
        '
        '   destinationFileName:
        '     The location to which the file should be copied.
        '
        '   overwrite:
        '     True if existing files should be overwritten; otherwise False. Default is False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     The system could not retrieve the absolute path.
        '
        '   T:System.ArgumentException:
        '     destinationFileName contains path information.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName or sourceFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing directory.
        '
        '   T:System.IO.IOException:
        '     The user does not have sufficient permissions to access the file.
        '
        '   T:System.IO.IOException:
        '     A file in the target directory with the same name is in use.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub CopyFile(sourceFileName As String, destinationFileName As String, overwrite As Boolean)

        End Sub
        '
        ' Summary:
        '     Copies a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     The file to be copied.
        '
        '   destinationFileName:
        '     The location to which the file should be copied.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   onUserCancel:
        '     Specifies what should be done if the user clicks Cancel during the operation.
        '     Default is Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     The system could not retrieve the absolute path.
        '
        '   T:System.ArgumentException:
        '     destinationFileName contains path information.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName or sourceFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The combined path points to an existing directory.
        '
        '   T:System.IO.IOException:
        '     The user does not have sufficient permissions to access the file.
        '
        '   T:System.IO.IOException:
        '     A file in the target directory with the same name is in use.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.OperationCanceledException:
        '     UICancelOption is set to ThrowException, and the user has canceled the operation
        '     or an unspecified I/O error occurs.
        Public Sub CopyFile(sourceFileName As String, destinationFileName As String, showUI As UIOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Creates a directory.
        '
        ' Parameters:
        '   directory:
        '     Name and location of the directory.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The directory name is malformed. For example, it contains illegal characters
        '     or is only white space.
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The directory name is too long.
        '
        '   T:System.NotSupportedException:
        '     The directory name is only a colon (:).
        '
        '   T:System.IO.IOException:
        '     The parent directory of the directory to be created is read-only
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have permission to create the directory.
        Public Sub CreateDirectory(directory As String)

        End Sub
        '
        ' Summary:
        '     Deletes a directory.
        '
        ' Parameters:
        '   directory:
        '     Directory to be deleted.
        '
        '   onDirectoryNotEmpty:
        '     Specifies what should be done when a directory that is to be deleted contains
        '     files or directories. Default is DeleteDirectoryOption.DeleteAllContents.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is a zero-length string, is malformed, contains only white space, or
        '     contains invalid characters (including wildcard characters). The path is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist or is a file.
        '
        '   T:System.IO.IOException:
        '     The directory is not empty, and onDirectoryNotEmpty is set to ThrowIfDirectoryNonEmpty.
        '
        '   T:System.IO.IOException:
        '     The user does not have permission to delete the directory or subdirectory.
        '
        '   T:System.IO.IOException:
        '     A file in the directory or subdirectory is in use.
        '
        '   T:System.NotSupportedException:
        '     The directory name contains a colon (:).
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.Security.SecurityException:
        '     The user does not have required permissions.
        '
        '   T:System.OperationCanceledException:
        '     The user cancels the operation or the directory cannot be deleted.
        Public Sub DeleteDirectory(directory As String, onDirectoryNotEmpty As DeleteDirectoryOption)

        End Sub
        '
        ' Summary:
        '     Deletes a directory.
        '
        ' Parameters:
        '   directory:
        '     Directory to be deleted.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   recycle:
        '     Specifies whether or not the deleted file should be sent to the Recycle Bin.
        '     Default is RecycleOption.DeletePermanently.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is a zero-length string, is malformed, contains only white space, or
        '     contains invalid characters (including wildcard characters). The path is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist or is a file.
        '
        '   T:System.IO.IOException:
        '     The directory is not empty, and onDirectoryNotEmpty is set to ThrowIfDirectoryNonEmpty.
        '
        '   T:System.IO.IOException:
        '     The user does not have permission to delete the directory or subdirectory.
        '
        '   T:System.IO.IOException:
        '     A file in the directory or subdirectory is in use.
        '
        '   T:System.NotSupportedException:
        '     The directory name contains a colon (:).
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.Security.SecurityException:
        '     The user does not have required permissions.
        '
        '   T:System.OperationCanceledException:
        '     The user cancels the operation or the directory cannot be deleted.
        Public Sub DeleteDirectory(directory As String, showUI As UIOption, recycle As RecycleOption)

        End Sub
        '
        ' Summary:
        '     Deletes a directory.
        '
        ' Parameters:
        '   directory:
        '     Directory to be deleted.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   recycle:
        '     Specifies whether or not the deleted file should be sent to the Recycle Bin.
        '     Default is RecycleOption.DeletePermanently.
        '
        '   onUserCancel:
        '     Specifies whether to throw an exception if the user clicks Cancel.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is a zero-length string, is malformed, contains only white space, or
        '     contains invalid characters (including wildcard characters). The path is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist or is a file.
        '
        '   T:System.IO.IOException:
        '     The directory is not empty, and onDirectoryNotEmpty is set to ThrowIfDirectoryNonEmpty.
        '
        '   T:System.IO.IOException:
        '     The user does not have permission to delete the directory or subdirectory.
        '
        '   T:System.IO.IOException:
        '     A file in the directory or subdirectory is in use.
        '
        '   T:System.NotSupportedException:
        '     The directory name contains a colon (:).
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.Security.SecurityException:
        '     The user does not have required permissions.
        '
        '   T:System.OperationCanceledException:
        '     The user cancels the operation or the directory cannot be deleted.
        Public Sub DeleteDirectory(directory As String, showUI As UIOption, recycle As RecycleOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Deletes a file.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file to be deleted.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; it has a trailing
        '     slash where a file must be specified; or it is a device path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.IOException:
        '     The file is in use.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have permission to delete the file or the file is read-only.
        Public Sub DeleteFile(file As String)

        End Sub
        '
        ' Summary:
        '     Deletes a file.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file to be deleted.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   recycle:
        '     Whether or not the deleted file should be sent to the Recycle Bin. Default is
        '     RecycleOption.DeletePermanently.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; it has a trailing
        '     slash where a file must be specified; or it is a device path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.IOException:
        '     The file is in use.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have permission to delete the file or the file is read-only.
        Public Sub DeleteFile(file As String, showUI As UIOption, recycle As RecycleOption)

        End Sub
        '
        ' Summary:
        '     Deletes a file.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file to be deleted.
        '
        '   showUI:
        '     Whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   recycle:
        '     Whether or not the deleted file should be sent to the Recycle Bin. Default is
        '     RecycleOption.DeletePermanently.
        '
        '   onUserCancel:
        '     Specifies whether or not an exception is thrown when the user cancels the operation.
        '     Default is UICancelOption.ThrowException.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; it has a trailing
        '     slash where a file must be specified; or it is a device path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.IO.IOException:
        '     The file is in use.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have permission to delete the file or the file is read-only.
        '
        '   T:System.OperationCanceledException:
        '     The user cancelled the operation and onUserCancel is set to Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException.
        Public Sub DeleteFile(file As String, showUI As UIOption, recycle As RecycleOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Moves a directory from one location to another.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     Path of the directory to be moved.
        '
        '   destinationDirectoryName:
        '     Path of the directory to which the source directory is being moved.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source is a root directory or The source path and the target path are the
        '     same.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub MoveDirectory(sourceDirectoryName As String, destinationDirectoryName As String)

        End Sub
        '
        ' Summary:
        '     Moves a directory from one location to another.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     Path of the directory to be moved.
        '
        '   destinationDirectoryName:
        '     Path of the directory to which the source directory is being moved.
        '
        '   overwrite:
        '     True if existing directories should be overwritten; otherwise False. Default
        '     is False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source is a root directory or The source path and the target path are the
        '     same.
        '
        '   T:System.IO.IOException:
        '     The target directory already exists and overwrite is set to False.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub MoveDirectory(sourceDirectoryName As String, destinationDirectoryName As String, overwrite As Boolean)

        End Sub
        '
        ' Summary:
        '     Moves a directory from one location to another.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     Path of the directory to be moved.
        '
        '   destinationDirectoryName:
        '     Path of the directory to which the source directory is being moved.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source is a root directory or The source path and the target path are the
        '     same.
        '
        '   T:System.IO.IOException:
        '     The target directory already exists and overwrite is set to False.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub MoveDirectory(sourceDirectoryName As String, destinationDirectoryName As String, showUI As UIOption)

        End Sub
        '
        ' Summary:
        '     Moves a directory from one location to another.
        '
        ' Parameters:
        '   sourceDirectoryName:
        '     Path of the directory to be moved.
        '
        '   destinationDirectoryName:
        '     Path of the directory to which the source directory is being moved.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   onUserCancel:
        '     Specifies whether or not an exception is thrown when the user cancels the operation.
        '     Default is UICancelOption.ThrowException.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.ArgumentNullException:
        '     sourceDirectoryName or destinationDirectoryName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The source is a root directory or The source path and the target path are the
        '     same.
        '
        '   T:System.IO.IOException:
        '     The target directory already exists and overwrite is set to False.
        '
        '   T:System.IO.IOException:
        '     onUserCancel is set to ThrowException and a subdirectory of the file cannot be
        '     copied.
        '
        '   T:System.OperationCanceledException:
        '     onUserCancel is set to ThrowException, and the user cancels the operation, or
        '     the operation cannot be completed.
        '
        '   T:System.Security.SecurityException:
        '     onUserCancel is set to ThrowException, and the user lacks necessary permissions.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.InvalidOperationException:
        '     The operation is cyclic.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub MoveDirectory(sourceDirectoryName As String, destinationDirectoryName As String, showUI As UIOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Moves a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     Path of the file to be moved.
        '
        '   destinationFileName:
        '     Path of the directory into which the file should be moved.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub MoveFile(sourceFileName As String, destinationFileName As String)

        End Sub
        '
        ' Summary:
        '     Moves a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     Path of the file to be moved.
        '
        '   destinationFileName:
        '     Path of the directory into which the file should be moved.
        '
        '   overwrite:
        '     True to overwrite existing files; otherwise False. Default is False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub MoveFile(sourceFileName As String, destinationFileName As String, overwrite As Boolean)

        End Sub
        '
        ' Summary:
        '     Moves a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     Path of the file to be moved.
        '
        '   destinationFileName:
        '     Path of the directory into which the file should be moved.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub MoveFile(sourceFileName As String, destinationFileName As String, showUI As UIOption)

        End Sub
        '
        ' Summary:
        '     Moves a file to a new location.
        '
        ' Parameters:
        '   sourceFileName:
        '     Path of the file to be moved.
        '
        '   destinationFileName:
        '     Path of the directory into which the file should be moved.
        '
        '   showUI:
        '     Specifies whether to visually track the operation's progress. Default is UIOption.OnlyErrorDialogs.
        '
        '   onUserCancel:
        '     Specifies whether or not an exception is thrown when the user cancels the operation.
        '     Default is UICancelOption.ThrowException.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     destinationFileName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The source file is not valid or does not exist.
        '
        '   T:System.IO.IOException:
        '     The destination file exists and overwrite is set to False.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.OperationCanceledException:
        '     onUserCancel is set to ThrowException, and either the user has cancelled the
        '     operation or an unspecified I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub MoveFile(sourceFileName As String, destinationFileName As String, showUI As UIOption, onUserCancel As UICancelOption)

        End Sub
        '
        ' Summary:
        '     Renames a directory.
        '
        ' Parameters:
        '   directory:
        '     Path and name of directory to be renamed.
        '
        '   newName:
        '     New name for directory.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     newName contains path information.
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing.-or-newName is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     There is an existing file or directory with the name specified in newName.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds 248 characters.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub RenameDirectory(directory As String, newName As String)

        End Sub
        '
        ' Summary:
        '     Renames a file.
        '
        ' Parameters:
        '   file:
        '     File to be renamed.
        '
        '   newName:
        '     New name of file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     newName contains path information or ends with a backslash (\).
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.-or-newName is Nothing or an empty string.
        '
        '   T:System.IO.FileNotFoundException:
        '     The directory does not exist.
        '
        '   T:System.IO.IOException:
        '     There is an existing file or directory with the name specified in newName.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user does not have required permission.
        Public Sub RenameFile(file As String, newName As String)

        End Sub
        '
        ' Summary:
        '     Writes data to a binary file.
        '
        ' Parameters:
        '   file:
        '     Path and name of the file to be written to.
        '
        '   data:
        '     Data to be written to the file.
        '
        '   append:
        '     True to append to the file contents; False to overwrite the file contents. Default
        '     is False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub WriteAllBytes(file As String, data() As Byte, append As Boolean)

        End Sub
        '
        ' Summary:
        '     Writes text to a file.
        '
        ' Parameters:
        '   file:
        '     File to be written to.
        '
        '   text:
        '     Text to be written to file.
        '
        '   append:
        '     True to append to the contents of the file; False to overwrite the contents of
        '     the file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub WriteAllText(file As String, text As String, append As Boolean)

        End Sub
        '
        ' Summary:
        '     Writes text to a file.
        '
        ' Parameters:
        '   file:
        '     File to be written to.
        '
        '   text:
        '     Text to be written to file.
        '
        '   append:
        '     True to append to the contents of the file; False to overwrite the contents of
        '     the file.
        '
        '   encoding:
        '     What encoding to use when writing to file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Sub WriteAllText(file As String, text As String, append As Boolean, encoding As Encoding)

        End Sub

        '
        ' Summary:
        '     Combines two paths and returns a properly formatted path.
        '
        ' Parameters:
        '   baseDirectory:
        '     String. First path to be combined.
        '
        '   relativePath:
        '     String. Second path to be combined.
        '
        ' Returns:
        '     The combination of the specified paths.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     baseDirectory or relativePath are malformed paths.
        Public Function CombinePath(baseDirectory As String, relativePath As String) As String

        End Function
        '
        ' Summary:
        '     Returns True if the specified directory exists.
        '
        ' Parameters:
        '   directory:
        '     Path of the directory.
        '
        ' Returns:
        '     True if the directory exists; otherwise False.
        Public Function DirectoryExists(directory As String) As Boolean

        End Function

        '
        ' Summary:
        '     Returns True if the specified file exists.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file.
        '
        ' Returns:
        '     Returns True if the file exists; otherwise this method returns False.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The name of the file ends with a backslash (\).
        Public Function FileExists(file As String) As Boolean

        End Function
        '
        ' Summary:
        '     Returns a read-only collection of strings representing the names of files containing
        '     the specified text.
        '
        ' Parameters:
        '   directory:
        '     The directory to be searched.
        '
        '   containsText:
        '     The search text.
        '
        '   ignoreCase:
        '     True if the search should be case-sensitive; otherwise False. Default is True.
        '
        '   searchType:
        '     Whether to include subfolders. Default is SearchOption.SearchTopLevelOnly.
        '
        ' Returns:
        '     Read-only collection of the names of files containing the specified text..
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The specified directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The specified directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     The specified directory path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function FindInFiles(directory As String, containsText As String, ignoreCase As Boolean, searchType As FileIO.SearchOption) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Returns a read-only collection of strings representing the names of files containing
        '     the specified text.
        '
        ' Parameters:
        '   directory:
        '     The directory to be searched.
        '
        '   containsText:
        '     The search text.
        '
        '   ignoreCase:
        '     True if the search should be case-sensitive; otherwise False. Default is True.
        '
        '   searchType:
        '     Whether to include subfolders. Default is SearchOption.SearchTopLevelOnly.
        '
        '   fileWildcards:
        '     Pattern to be matched.
        '
        ' Returns:
        '     Read-only collection of the names of files containing the specified text..
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The specified directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The specified directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     The specified directory path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function FindInFiles(directory As String, containsText As String, ignoreCase As Boolean, searchType As FileIO.SearchOption, ParamArray fileWildcards() As String) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Returns a collection of strings representing the path names of subdirectories
        '     within a directory.
        '
        ' Parameters:
        '   directory:
        '     Name and path of directory.
        '
        ' Returns:
        '     Read-only collection of the path names of subdirectories within the specified
        '     directory..
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The specified directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The specified directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function GetDirectories(directory As String) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Returns a collection of strings representing the path names of subdirectories
        '     within a directory.
        '
        ' Parameters:
        '   directory:
        '     Name and path of directory.
        '
        '   searchType:
        '     Whether to include subfolders. Default is SearchOption.SearchTopLevelOnly.
        '
        '   wildcards:
        '     Pattern to match names.
        '
        ' Returns:
        '     Read-only collection of the path names of subdirectories within the specified
        '     directory.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.ArgumentNullException:
        '     One or more of the specified wildcard characters is Nothing, an empty string,
        '     or contains only spaces.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The specified directory does not exist.
        '
        '   T:System.IO.IOException:
        '     The specified directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function GetDirectories(directory As String, searchType As FileIO.SearchOption, ParamArray wildcards() As String) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Returns a System.IO.DirectoryInfo object for the specified path.
        '
        ' Parameters:
        '   directory:
        '     String. Path of directory.
        '
        ' Returns:
        '     System.IO.DirectoryInfo object for the specified path.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     The directory path contains a colon (:) or is in an invalid format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path
        Public Function GetDirectoryInfo(directory As String) As DirectoryInfo

        End Function
        '
        ' Summary:
        '     Returns a System.IO.DriveInfo object for the specified drive.
        '
        ' Parameters:
        '   drive:
        '     Drive to be examined.
        '
        ' Returns:
        '     System.IO.DriveInfo object for the specified drive.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     drive is Nothing or an empty string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path
        Public Function GetDriveInfo(drive As String) As DriveInfo

        End Function
        '
        ' Summary:
        '     Returns a System.IO.FileInfo object for the specified file.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file.
        '
        ' Returns:
        '     System.IO.FileInfo object for the specified file
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path name is malformed. For example, it contains invalid characters or is
        '     only white space. The file name has a trailing slash mark.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing or an empty string.
        '
        '   T:System.NotSupportedException:
        '     The path contains a colon in the middle of the string.
        '
        '   T:System.IO.PathTooLongException:
        '     The path is too long.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks ACL (access control list) access to the file.
        Public Function GetFileInfo(file As String) As FileInfo

        End Function
        '
        ' Summary:
        '     Returns a read-only collection of strings representing the names of files within
        '     a directory.
        '
        ' Parameters:
        '   directory:
        '     Directory to be searched.
        '
        ' Returns:
        '     Read-only collection of file names from the specified directory.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory to search does not exist.
        '
        '   T:System.IO.IOException:
        '     directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function GetFiles(directory As String) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Returns a read-only collection of strings representing the names of files within
        '     a directory.
        '
        ' Parameters:
        '   directory:
        '     Directory to be searched.
        '
        '   searchType:
        '     Whether to include subfolders. Default is SearchOption.SearchTopLevelOnly.
        '
        '   wildcards:
        '     Pattern to be matched.
        '
        ' Returns:
        '     Read-only collection of file names from the specified directory.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentNullException:
        '     directory is Nothing.
        '
        '   T:System.IO.DirectoryNotFoundException:
        '     The directory to search does not exist.
        '
        '   T:System.IO.IOException:
        '     directory points to an existing file.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        '
        '   T:System.UnauthorizedAccessException:
        '     The user lacks necessary permissions.
        Public Function GetFiles(directory As String, searchType As FileIO.SearchOption, ParamArray wildcards() As String) As ReadOnlyCollection(Of String)

        End Function
        '
        ' Summary:
        '     Parses the file name out of the path provided.
        '
        ' Parameters:
        '   path:
        '     Required. Path to be parsed. String.
        '
        ' Returns:
        '     The file name from the specified path.
        Public Function GetName(path As String) As String

        End Function
        '
        ' Summary:
        '     Returns the parent path of the provided path.
        '
        ' Parameters:
        '   path:
        '     Path to be examined.
        '
        ' Returns:
        '     The parent path of the provided path.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\).
        '
        '   T:System.ArgumentException:
        '     Path does not have a parent path because it is a root path.
        '
        '   T:System.ArgumentNullException:
        '     path is Nothing.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        Public Function GetParentPath(path As String) As String

        End Function
        '
        ' Summary:
        '     Creates a uniquely named zero-byte temporary file on disk and returns the full
        '     path of that file.
        '
        ' Returns:
        '     String containing the full path of the temporary file.
        Public Function GetTempFileName() As String

        End Function
        '
        ' Summary:
        '     The OpenTextFieldParser method allows you to create a Microsoft.VisualBasic.FileIO.TextFieldParser
        '     object, which provides a way to easily and efficiently parse structured text
        '     files, such as logs. The TextFieldParser object can be used to read both delimited
        '     and fixed-width files.
        '
        ' Parameters:
        '   file:
        '     The file to be opened with the TextFieldParser.
        '
        ' Returns:
        '     Microsoft.VisualBasic.FileIO.TextFieldParser to read the specified file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:Microsoft.VisualBasic.FileIO.MalformedLineException:
        '     A row cannot be parsed using the specified format. The exception message specifies
        '     the line causing the exception, while the Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine
        '     property is assigned the text contained in the line.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function OpenTextFieldParser(file As String) As TextFieldParser

        End Function
        '
        ' Summary:
        '     The OpenTextFieldParser method allows you to create a Microsoft.VisualBasic.FileIO.TextFieldParser
        '     object, which provides a way to easily and efficiently parse structured text
        '     files, such as logs. The TextFieldParser object can be used to read both delimited
        '     and fixed-width files.
        '
        ' Parameters:
        '   file:
        '     The file to be opened with the TextFieldParser.
        '
        '   delimiters:
        '     Delimiters for the fields.
        '
        ' Returns:
        '     Microsoft.VisualBasic.FileIO.TextFieldParser to read the specified file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:Microsoft.VisualBasic.FileIO.MalformedLineException:
        '     A row cannot be parsed using the specified format. The exception message specifies
        '     the line causing the exception, while the Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine
        '     property is assigned the text contained in the line.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function OpenTextFieldParser(file As String, ParamArray delimiters() As String) As TextFieldParser

        End Function
        '
        ' Summary:
        '     The OpenTextFieldParser method allows you to create a Microsoft.VisualBasic.FileIO.TextFieldParser
        '     object, which provides a way to easily and efficiently parse structured text
        '     files, such as logs. The TextFieldParser object can be used to read both delimited
        '     and fixed-width files.
        '
        ' Parameters:
        '   file:
        '     The file to be opened with the TextFieldParser.
        '
        '   fieldWidths:
        '     Widths of the fields.
        '
        ' Returns:
        '     Microsoft.VisualBasic.FileIO.TextFieldParser to read the specified file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:Microsoft.VisualBasic.FileIO.MalformedLineException:
        '     A row cannot be parsed using the specified format. The exception message specifies
        '     the line causing the exception, while the Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine
        '     property is assigned the text contained in the line.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function OpenTextFieldParser(file As String, ParamArray fieldWidths() As Integer) As TextFieldParser

        End Function
        '
        ' Summary:
        '     Opens a System.IO.StreamReader object to read from a file.
        '
        ' Parameters:
        '   file:
        '     File to be read.
        '
        ' Returns:
        '     System.IO.StreamReader object to read from the file
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The file name ends with a backslash (\).
        '
        '   T:System.IO.FileNotFoundException:
        '     The specified file cannot be found.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to read from the file.
        Public Function OpenTextFileReader(file As String) As StreamReader

        End Function
        '
        ' Summary:
        '     Opens a System.IO.StreamReader object to read from a file.
        '
        ' Parameters:
        '   file:
        '     File to be read.
        '
        '   encoding:
        '     The encoding to use for the file contents. Default is ASCII.
        '
        ' Returns:
        '     System.IO.StreamReader object to read from the file
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The file name ends with a backslash (\).
        '
        '   T:System.IO.FileNotFoundException:
        '     The specified file cannot be found.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to read from the file.
        Public Function OpenTextFileReader(file As String, encoding As Encoding) As StreamReader

        End Function
        '
        ' Summary:
        '     Opens a System.IO.StreamWriter object to write to the specified file.
        '
        ' Parameters:
        '   file:
        '     File to be written to.
        '
        '   append:
        '     True to append to the contents of the file; False to overwrite the contents of
        '     the file. Default is False.
        '
        ' Returns:
        '     System.IO.StreamWriter object to write to the specified file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The file name ends with a trailing slash.
        Public Function OpenTextFileWriter(file As String, append As Boolean) As StreamWriter

        End Function
        '
        ' Summary:
        '     Opens a System.IO.StreamWriter to write to the specified file.
        '
        ' Parameters:
        '   file:
        '     File to be written to.
        '
        '   append:
        '     True to append to the contents in the file; False to overwrite the contents of
        '     the file. Default is False.
        '
        '   encoding:
        '     Encoding to be used in writing to the file. Default is ASCII.
        '
        ' Returns:
        '     System.IO.StreamWriter object to write to the specified file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The file name ends with a trailing slash.
        Public Function OpenTextFileWriter(file As String, append As Boolean, encoding As Encoding) As StreamWriter

        End Function
        '
        ' Summary:
        '     Returns the contents of a file as a byte array.
        '
        ' Parameters:
        '   file:
        '     File to be read.
        '
        ' Returns:
        '     Byte array containing the contents of the file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function ReadAllBytes(file As String) As Byte()

        End Function
        '
        ' Summary:
        '     Returns the contents of a text file as a String.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file to read.
        '
        ' Returns:
        '     String containing the contents of the file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function ReadAllText(file As String) As String

        End Function
        '
        ' Summary:
        '     Returns the contents of a text file as a String.
        '
        ' Parameters:
        '   file:
        '     Name and path of the file to read.
        '
        '   encoding:
        '     Character encoding to use in reading the file. Default is UTF-8.
        '
        ' Returns:
        '     String containing the contents of the file.
        '
        ' Exceptions:
        '   T:System.ArgumentException:
        '     The path is not valid for one of the following reasons: it is a zero-length string;
        '     it contains only white space; it contains invalid characters; or it is a device
        '     path (starts with \\.\); it ends with a trailing slash.
        '
        '   T:System.ArgumentNullException:
        '     file is Nothing.
        '
        '   T:System.IO.FileNotFoundException:
        '     The file does not exist.
        '
        '   T:System.IO.IOException:
        '     The file is in use by another process, or an I/O error occurs.
        '
        '   T:System.IO.PathTooLongException:
        '     The path exceeds the system-defined maximum length.
        '
        '   T:System.NotSupportedException:
        '     A file or directory name in the path contains a colon (:) or is in an invalid
        '     format.
        '
        '   T:System.OutOfMemoryException:
        '     There is not enough memory to write the string to buffer.
        '
        '   T:System.Security.SecurityException:
        '     The user lacks necessary permissions to view the path.
        Public Function ReadAllText(file As String, encoding As Encoding) As String

        End Function
    End Class
End Namespace
